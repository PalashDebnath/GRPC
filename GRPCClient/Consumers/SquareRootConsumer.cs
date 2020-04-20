using System;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using SquareRootPackage;
using static SquareRootPackage.SquareRootService;

namespace GRPCClient
{
    public class SquareRootConsumer
    {
        private Channel _channel;
        private SquareRootRequest _squareRootRequest;
        private SquareRootServiceClient _squareRootServiceClient;

        public SquareRootConsumer(Channel channel)
        {
            _channel = channel;
            _squareRootRequest = new SquareRootRequest() { Number = -16 };
            _squareRootServiceClient = new SquareRootServiceClient(_channel);
        }

        public void CallUnaryService(Action<string> action)
        {
            try
            {
                var squareRootResponse = _squareRootServiceClient.SquareRootUnary(_squareRootRequest);
                action(squareRootResponse.Result.ToString());
            }
            catch (RpcException e)
            {
                action(String.Format("Error status: {0} message: {1}", e.StatusCode, e.Status.Detail));
            }
        }
    }
}