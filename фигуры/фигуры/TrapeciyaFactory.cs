using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    class TrapeciyaFactory : FigyraFactory
    {
        public override ICalculateArea Create( string name, double[] parametrs)
        {
            return new Trapeciya(parametrs[1], parametrs[2], parametrs[3], name);
        }
    }
}
