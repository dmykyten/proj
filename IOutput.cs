﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public interface IOutput
    {
        void WriteLine(string text);
        void Write(string text);
    }
}
