using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLabLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("neche eded daxil etmek isteyirsiz");
            int ededSayi = int.Parse(Console.ReadLine());
            int[] Numbers = new int[ededSayi];
            Console.WriteLine("ededleri daxil edin:");
            int cut = 0;
            int tek = 0;
            int k = 0;
            int c = 0;
            for ( int i=0; i<=ededSayi-1; i++)
            {
                Console.WriteLine(i+1 +"-ci ededi daxil edn:");
                Numbers[i] = int.Parse(Console.ReadLine());
                //Console.Clear();
                if(Numbers[i]%2==0)
                {
                    cut += Numbers[i];
                    k++;
                }
                else
                {
                    tek += Numbers[i];
                    c++;
                }
              
            }
            Console.WriteLine("Cut ededlerin cemi beraberdir:" + cut + "\n cut ededlerin cemi" + k);
            Console.WriteLine("Tek ededlerin sayi beraberdir:" + tek + "\n tek ededlerin sayi" + c);
            Console.ReadKey();
        }
    }
}
