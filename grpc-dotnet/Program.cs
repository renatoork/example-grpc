using System;
using System.Threading;
using Grpc.Core;
using Mega.Bim.ItemsService;

namespace Mega.Bim
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server
            {
                // TODO DI
                Services = { Items.BindService(new ItemService()) },
                Ports = { new ServerPort("0.0.0.0", 50051, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"GRPC server listening on port {50051}");
            Console.WriteLine("After server start");
            Thread.Sleep(Timeout.Infinite);
            Console.WriteLine("After wait");
        }
    }
}
