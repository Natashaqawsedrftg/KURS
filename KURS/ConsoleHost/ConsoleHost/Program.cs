using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ServerBD;


namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {  
            ServiceHost host = new ServiceHost(typeof(ServBD), new Uri("http://localhost:8080/"));
            
            host.Open();
            #region Output dispatchers listening
            foreach (Uri uri in host.BaseAddresses)
            { Console.WriteLine("\t{0}", uri.ToString()); }
            Console.WriteLine();
            Console.WriteLine("Count and list of listening : {0}", host.ChannelDispatchers.Count);
            foreach (System.ServiceModel.Dispatcher.ChannelDispatcher dispatcher in host.ChannelDispatchers)
            {
                Console.WriteLine("\t{0}, {1}", dispatcher.Listener.Uri.ToString(), dispatcher.BindingName);
            }
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to stop the host");
            Console.ReadLine();
            #endregion


        }
    }
        }

