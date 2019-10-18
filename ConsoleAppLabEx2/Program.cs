using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLabEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("B ededini daxil edin :");
            int b= int.Parse(Console.ReadLine());


            int cem = a + b;

            int hasil = a * b;
            int ferq;
            double bolme;

            if (a > b)
            {
                ferq = a - b;
                bolme =(double) a / b;
            }
            else
            {
                ferq = b - a;
                bolme =(double) b / a;
            }

            Console.WriteLine("Cem=" + cem + "\n"+ "ferq=" + ferq +"\n"+ "hasil=" + hasil+ "\n" +"qaliq=" + bolme) ;
            Console.ReadKey();
        }
    }
}
