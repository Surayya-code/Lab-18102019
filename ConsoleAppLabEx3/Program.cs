using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLabEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilkin Mesafeni daxil edin:");
            double mesafe =int.Parse( Console.ReadLine());
            double dist = 10;
            int gun =1;

            while(dist <=mesafe)
            {
                dist += dist * 0.1;
                gun++;
            }
            Console.WriteLine("Idmanci getdiyi " +gun +  "  erzinde"+dist+  " km mesafe qet edib");
            Console.ReadKey();
        }
    }
}
