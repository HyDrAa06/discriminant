using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дискриминанта_на_квадратно_уравнение
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminant;
            Console.Write("a= ");
            a=double.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c= ");
            c = double.Parse(Console.ReadLine());

            discriminant = b * b -4 * a * c;

            Console.Write("Discriminant= {0}",discriminant);
            

            Console.ReadLine();
        }
    }
}
