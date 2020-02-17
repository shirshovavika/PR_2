using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    class KvadratFactory : FigyraFactory
    {
        public override ICalculateArea Create(string name, double[] parametrs)
        {
            return new Kvadrat( parametrs[1], parametrs[2],name);
        }
    }
}
