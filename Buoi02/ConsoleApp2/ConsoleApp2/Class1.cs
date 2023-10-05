using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace ConsoleApp2
{
     class Class1
    {

        public String PortID()
        {
            string prottt;
            IPAddress[] add = Dns.GetHostAddresses("LAPTOP-ALA9RHJO");
            foreach (IPAddress ip in add)
            {
                IPEndPoint por = new IPEndPoint(ip, 10000);
                Console.WriteLine(por.ToString());
                prottt = por.ToString();
            }
           
            return PortID();


        }
       
    }
}
