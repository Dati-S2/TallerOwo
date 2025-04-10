using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(0.6f, 0.25f);
            Triangulo t2 = new Triangulo("0.6", "0.25");

            Console.WriteLine(t1.Area());

            Console.ReadLine();

            new Rectangulo(6f,3f);

            new Circulo(3f);

        }
            
    }
}
