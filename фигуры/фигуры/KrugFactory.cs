using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    class KrugFactory:FigyraFactory
    {
        public override ICalculateArea Create( string name,double[] parametrs)
        {
            return new Kryg(name, parametrs[0]);
        }
    }
}
