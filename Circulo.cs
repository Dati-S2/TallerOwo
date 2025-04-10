using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Circulo
    {
        private float rd;

        public Circulo (float rd)
        { 
            this.rd = rd; 
        }
        public float Area() => 3.1415f *(rd * rd);
    }
}
