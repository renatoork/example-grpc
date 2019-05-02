

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Mega.Bim.ItemsService
{
    public class ItemService : Items.ItemsBase
    {
        public override async Task<Result> sendItems(IAsyncStreamReader<Item> requestStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext(new CancellationToken(false)))
            {
                Console.WriteLine(requestStream.Current);
            }
            return new Result { Message = "Ok" };

        }
    }
}