using System;
using System.Linq;
using System.Threading.Tasks;
using GreetPackage;
using Grpc.Core;
using static GreetPackage.GreetService;

namespace GRPCClient
{
    public class GreetConsumer
    {
        private Channel _channel;
        private Greet _greet;
        private GreetRequest _greetRequest;
        private GreetServiceClient _greetServiceClient;

        public GreetConsumer(Channel channel)
        {
            _channel = channel;
            _greet = new Greet() { FirstName = "Palash", LastName = "Debnath" };
            _greetRequest = new GreetRequest() { Greet = _greet };
            _greetServiceClient = new GreetServiceClient(_channel);
        }

        public void CallUnaryService(Action<string> action)
        {
            try
            {
                //Here in the client we specify a deadline
                var greetResponse = _greetServiceClient.GreetUnary(_greetRequest, deadline: DateTime.UtcNow.AddMilliseconds(100));
                action(greetResponse.Response);
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.DeadlineExceeded)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }

        public async Task CallStreamingService(Action<string> action)
        {
            var greetResponse = _greetServiceClient.GreetServerStream(_greetRequest);

            while (await greetResponse.ResponseStream.MoveNext())
            {
                action(greetResponse.ResponseStream.Current.Response);
                await Task.Delay(200);
            }
        }

        public async Task CallStreamingClient(Action<string> action)
        {
            var requestStream = _greetServiceClient.GreetClientStream();
            foreach (var item in Enumerable.Range(1, 10))
            {
                await requestStream.RequestStream.WriteAsync(_greetRequest);
            }
            await requestStream.RequestStream.CompleteAsync();

            var greetResponse = await requestStream.ResponseAsync;

            action(greetResponse.Response);
        }

        public async Task CallFullStreaming(Action<string> action)
        {
            var requestStream = _greetServiceClient.GreetFullStream();
            var responseStream = Task.Run(async () => {
                while (await requestStream.ResponseStream.MoveNext())
                {
                    action(requestStream.ResponseStream.Current.Response);
                    await Task.Delay(200);
                }
            });
            foreach (var item in Enumerable.Range(1, 10))
            {
                await requestStream.RequestStream.WriteAsync(_greetRequest);
            }
            await requestStream.RequestStream.CompleteAsync();
            await responseStream;
        }
    }
}