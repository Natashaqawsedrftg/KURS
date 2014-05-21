using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ServerBD;

namespace ConsoleClient
{
    public class Program
    {
        static public string Main1(string u)
        { string ss="";
         ServerClient s = new ServerClient();
           ss= Convert.ToString(s.DoQuery(u, true));
           return ss;
        }
    }
}
