using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public class Pryamoygolnik : Quadrangle, ICalculateArea
    {
        private string myName;
        string ICalculateArea.Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName=value;
            }
        }
        public Pryamoygolnik( double a, double b, string name) : base(a, b)
        {
            
        }
        public double CalculateArea()
        {
            
            double s = a * b;
            return s;
        }
        
    }
}
