﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_visitor.Sources
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
