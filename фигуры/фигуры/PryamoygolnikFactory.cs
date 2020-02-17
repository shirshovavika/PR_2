using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    class PryamoygolnikFactory : FigyraFactory
    {
        public override ICalculateArea Create(string name, double[] parametrs)
        {
            return new Pryamoygolnik (parametrs[1], parametrs[2], name);
        }
    }
}
