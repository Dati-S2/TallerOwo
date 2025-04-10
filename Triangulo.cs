using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Triangulo
    {
        private float b;
        private float h;

        public Triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;            
        }
        public Triangulo(string b, string h)
        {
            this.b = float.Parse(b);
            this.h = float.Parse(h);
        }

        public float Area() => b * h / 2;
        
    }
}
