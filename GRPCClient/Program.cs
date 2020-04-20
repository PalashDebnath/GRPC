using System;
using System.Threading.Tasks;

namespace GRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = ChannelWrapper.Factory();
            var greetConsumer = new GreetConsumer(channel);
            Console.WriteLine();
            Console.WriteLine("Unary service call!!!");
            greetConsumer.CallUnaryService(fn => { Console.WriteLine(fn); });
            Console.WriteLine();
            Console.WriteLine("Streaming service call!!!");
            await greetConsumer.CallStreamingService(fn => { Console.WriteLine(fn); });
            Console.WriteLine();
            Console.WriteLine("Streaming client call!!!");
            await greetConsumer.CallStreamingClient(fn => { Console.WriteLine(fn); });
            Console.WriteLine("Streaming client & server call!!!");
            await greetConsumer.CallFullStreaming(fn => { Console.WriteLine(fn); });

            var squarRootConsumer = new SquareRootConsumer(channel);
            Console.WriteLine();
            Console.WriteLine("Unary service call!!!");
            squarRootConsumer.CallUnaryService(fn => { Console.WriteLine(fn); });

            var blogConsumer = new BlogConsumer(channel);
            Console.WriteLine();
            Console.WriteLine("Unary create service call!!!");
            blogConsumer.CallUnaryCreateBlogService(fn => { Console.WriteLine(fn); });
            Console.WriteLine();
            Console.WriteLine("Unary read service call!!!");
            blogConsumer.CallUnaryReadBlogService(fn => { Console.WriteLine(fn); });
            Console.WriteLine();
            Console.WriteLine("Unary update service call!!!");
            blogConsumer.CallUnaryUpdateBlogService(fn => { Console.WriteLine(fn); });
            Console.WriteLine();
            Console.WriteLine("Unary delete service call!!!");
            blogConsumer.CallUnaryDeleteBlogService(fn => { Console.WriteLine(fn); });

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }
    }
}
