using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    class TreygolnikFactory : FigyraFactory
    {
        public override ICalculateArea Create(string name, double[] parametrs)
        {
            return new Treygolnik(parametrs[1], parametrs[2], name);
        }
    }
}
