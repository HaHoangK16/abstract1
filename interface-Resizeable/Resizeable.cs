﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace interface_Resizeable
{
    interface Resizeable
    {
        public void Resize(double percent);
        public double ReSize(double percent);
    }
}
