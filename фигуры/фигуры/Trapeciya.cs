using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public class Trapeciya : Quadrangle, ICalculateArea
    {
        private double visota;
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
        public Trapeciya( double visota, double a, double b, string name) : base(a, b)
        {
            this.visota = visota;
        }
        public double GetVisota()
        {
            return this.visota;
        }
        public  double CalculateArea()
        {
            double s = (visota*(a + b)) / 2;
            return s;
        }
        
    }
}
