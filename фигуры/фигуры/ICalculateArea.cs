using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public interface ICalculateArea
    {
        public double CalculateArea();
        public string Name { get; set; }
        public virtual void PokajiPowad()
        {
            Console.WriteLine(this.Name + "," + "Площадь" + "=" + this.CalculateArea());
        }
    }
}
