using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

using FileTaggingService;

namespace TestServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IFileTagGetter> httpFactory =
              new ChannelFactory<IFileTagGetter>(
                new BasicHttpBinding(),
                new EndpointAddress(
                  "http://localhost:8000/GetFileTag"));

            IFileTagGetter httpProxy = httpFactory.CreateChannel();

            while(true)
            {
                string str = Console.ReadLine();
                Console.WriteLine("http: " + httpProxy.GetFileTag(str));
            }
        }
    }
}
