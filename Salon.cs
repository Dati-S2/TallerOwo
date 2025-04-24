using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Salon
    {
        public void Start ()
        {
            List<Alumno> lista = new List<Alumno>();

            Console.WriteLine("que desesas realizar");

            switch (Console.ReadLine())
            {
                case "agrear un alumno":

                    Console.WriteLine("Ingresa los datos: Nombre, promedio 1, promedio 2, promedio 3");
                    string nombre = Console.ReadLine();
                    float p1 = float.Parse(Console.ReadLine());
                    float p2 = float.Parse(Console.ReadLine());
                    float p3 = float.Parse(Console.ReadLine());


                    Alumno alumno = new Alumno(nombre,p1,p2, p3);
                    lista.Add(alumno);

                break;
               
                case "remover un alumno":
                   


                break;
                

            }
        }


    }
}
