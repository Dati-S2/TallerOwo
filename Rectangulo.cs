﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    internal class Rectangulo
    {
        private float b;
        private float h;

        public Rectangulo (float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public float Area() => b * h;
    }
}
