using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    abstract class FigyraFactory
    {
        abstract public ICalculateArea Create(string name, double[]parametrs);
    }
}
