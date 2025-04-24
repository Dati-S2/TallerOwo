using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Alumno
    {
        private string nombre;
        private float p1;
        private float p2;
        private float p3;

        public Alumno (string nombre, float p1, float p2, float p3)
        {
            this.nombre = nombre;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            
        }
        public float PromedioTLS()
        { return (p1 + p2 + (p3*2)) / 3; }

    }
}
