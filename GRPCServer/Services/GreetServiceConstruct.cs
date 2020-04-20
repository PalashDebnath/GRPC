using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetPackage;
using Grpc.Core;
using static GreetPackage.GreetService;

namespace GRPCServer
{
    public class GreetServiceConstruct : GreetServiceBase
    {
        public override async Task<GreetResponse> GreetUnary(GreetPackage.GreetRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal greet request. Server will response normally!!!");
            //To set up the deadline we delay the task
            //If the client deadlie to not meet with the server it will throw a deadline error
            await Task.Delay(300);
            string response = string.Format("Hello {0} {1}", request.Greet.FirstName, request.Greet.LastName);
            return new GreetResponse(){ Response = response };
        }
        
        public override async Task GreetServerStream(GreetRequest request, Grpc.Core.IServerStreamWriter<GreetResponse> responseStream, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal greet request. Server will response with a stream!!!");
            string response = string.Format("Hello {0} {1}", request.Greet.FirstName, request.Greet.LastName);
            foreach (var item in Enumerable.Range(1, 10))
            {
                await responseStream.WriteAsync(new GreetResponse() { Response = response });
            }
        }

        public override async Task<GreetResponse> GreetClientStream(Grpc.Core.IAsyncStreamReader<GreetRequest> requestStream, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a stream greet request. Server will response normally!!!");
            StringBuilder build = new StringBuilder();
            while (await requestStream.MoveNext())
            {
                build.Append("Hello ");
                build.Append(requestStream.Current.Greet.FirstName);
                build.Append(" ");
                build.Append(requestStream.Current.Greet.LastName);
                build.Append(Environment.NewLine);
            }
            return new GreetResponse() { Response = build.ToString() };
        }

        public override async Task GreetFullStream(IAsyncStreamReader<GreetRequest> requestStream, IServerStreamWriter<GreetResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine("Server received a stream greet request. Server will response with a stream!!!");
            StringBuilder build = new StringBuilder();
            while (await requestStream.MoveNext())
            {
                build.Clear();
                build.Append("Hello ");
                build.Append(requestStream.Current.Greet.FirstName);
                build.Append(" ");
                build.Append(requestStream.Current.Greet.LastName);       

                await responseStream.WriteAsync(new GreetResponse(){ Response = build.ToString() }); 
            }
        }
    }
}