using System;
using System.Threading.Tasks;
using Grpc.Core;
using SquareRootPackage;
using static SquareRootPackage.SquareRootService;

namespace GRPCServer
{
    public class SquareRootServiceConstruct : SquareRootServiceBase
    {
        public override Task<SquareRootResponse> SquareRootUnary(SquareRootPackage.SquareRootRequest request, Grpc.Core.ServerCallContext context)
        {
            Console.WriteLine("Server received a normal square root request. Server will response normally!!!");
            int number = request.Number;
            if(number >= 0)
                return Task.FromResult(new SquareRootResponse() { Result = Math.Sqrt(number) });
            else
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Negative Value { number < 0 }"));
        }
    }
}