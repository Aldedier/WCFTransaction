using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WCFTransactionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            using (var catalog = new CatalogServiceClient())
            {
                catalog.AddProduct("Producto 16", new Uri("http://miimage.com"));
                scope.Complete();
            }
            Console.WriteLine("Terminado");
            Console.ReadKey();
        }
    }
}
