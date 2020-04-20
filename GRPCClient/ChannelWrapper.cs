using System;
using System.IO;
using System.Threading.Tasks;
using Grpc.Core;

namespace GRPCClient
{
    public static class ChannelWrapper
    {
        public static Channel Factory()
        {
            //const string _target = "127.0.0.1:5001";
            const int _port = 5001;
            string clientCertificate = File.ReadAllText("GRPCClient/ssl/client.crt");
            string clientKey = File.ReadAllText("GRPCClient/ssl/client.key");
            string caCertificate = File.ReadAllText("GRPCClient/ssl/ca.crt");
            SslCredentials channelCredentials = new SslCredentials(caCertificate, new KeyCertificatePair(clientCertificate, clientKey));

            Channel channel = new Channel("localhost", _port, channelCredentials);

            channel.ConnectAsync().ContinueWith((task) =>
            {
                if(task.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("The client connected successfully");
                }
            });

            return channel;
        }
    }
}