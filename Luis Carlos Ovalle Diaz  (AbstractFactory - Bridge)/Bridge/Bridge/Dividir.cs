﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Dividir : Implementor
    {
        public int operacion(int a, int b)
        {
            return a / b;
        }
    }
}
