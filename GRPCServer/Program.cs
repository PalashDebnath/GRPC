using System;
using System.Collections.Generic;
using System.IO;
using BlogPackage;
using GreetPackage;
using Grpc.Core;
using SquareRootPackage;

namespace GRPCServer
{
    class Program
    {
        private const int _port = 5001;
        
        static void Main(string[] args)
        {
            Server server = null;            
            try
            {
                string serverCertificate = File.ReadAllText("GRPC.Server/ssl/server.crt");
                string serverKey = File.ReadAllText("GRPC.Server/ssl/server.key");
                string caCertificate = File.ReadAllText("GRPC.Server/ssl/ca.crt");
                SslServerCredentials serverCredentials = new SslServerCredentials(new List<KeyCertificatePair>(){ new KeyCertificatePair(serverCertificate, serverKey) }, caCertificate, true);

                server = new Server()
                {
                    Services = { GreetService.BindService(new GreetServiceConstruct()),
                                 SquareRootService.BindService(new SquareRootServiceConstruct()),
                                 BlogService.BindService(new BlogServiceConstruct())
                               },
                    Ports = { new ServerPort("localhost", _port, serverCredentials) }
                };

                server.Start();
                Console.WriteLine("The sever is listening on port: " + _port);
                Console.ReadKey();
            }
            catch(IOException e)
            {
                Console.WriteLine("The _server is failed to start " + e.Message);
            }
            finally
            {
                if (server != null)
                {
                    server.ShutdownAsync().Wait();
                }
            }
        }
    }
}
