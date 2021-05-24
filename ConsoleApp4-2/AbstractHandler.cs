﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_2
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
}
