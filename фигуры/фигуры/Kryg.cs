using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public class Kryg : ICalculateArea

    {
        private double radius;
        private string myName;
        string ICalculateArea.Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }
        public Kryg(string name, double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return this.radius;
        }
        public double CalculateArea()
        {
            double pi;
            double s;
            pi= 3.14;
            s = (radius * radius) * pi;
            return s;
        }
    }
}
