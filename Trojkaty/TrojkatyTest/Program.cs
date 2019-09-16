using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat x;
            x = new Trojkat(2, 1, 2.5);
            Console.WriteLine(x);
            Console.WriteLine(x.Obwod() ); //funkcja obwod
            Console.WriteLine(x.Obwód ); // properties get obwod
            //x.C = 1;
            Console.WriteLine(x.Obwód);
            Console.WriteLine(x.Pole);
            {
                Trojkat y = new Trojkat();
                Console.WriteLine(y);
            }
            
        }
    }
}
