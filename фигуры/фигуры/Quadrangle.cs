using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public abstract class Quadrangle
    {
        protected double a;
        protected double b;
        public Quadrangle(double a, double b) 
        {
            this.a = a;
            this.b = b;
        }
        public double GetA()
        {
            return this.a;
        }
        public double GetB()
        {
            return this.b;
        }
 
    }
}
