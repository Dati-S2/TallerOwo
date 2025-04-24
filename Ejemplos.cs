using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Ejemplos
    {

        public void Start()
        {
            Triangulo t1 = new Triangulo(3, 7);
            Triangulo t2 = new Triangulo(4, 8);

            Triangulo[] tris = { t1, t2, new Triangulo(5, 6) };
            //tris[3] = new Triangulo(4, 5); //error xq no hay ese espacio

            List<Triangulo> lista = new List<Triangulo>();
            lista.Add(t1);
            lista.Add(t2);
            lista.Add(new Triangulo(4,5));
            
            Console.WriteLine(lista.Count); //con esto se peude ver cuantos elementos hay en esta lista

            lista.Add(new Triangulo(5, 2));

            Console.WriteLine(lista.Count);

            Triangulo r = lista.Find(x => x.Area() == 5); //va buscar si un triangulo tiene como area == 5
            lista.Remove(r); //eliminara ese triangulo

            Console.WriteLine(lista.Count);

            foreach (Triangulo t in lista) //por cada triangulo en la lista va ejecutar lo de abajo
            {
                Console.WriteLine(t.Area());
            }

        }
    }
}
