using System;
using System.Collections.Generic;
using System.Text;

namespace фигуры
{
    public class Treygolnik:  ICalculateArea
    {
        private double visota;
        private double storona;
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
        public Treygolnik(double visota, double storona,string name) 
        {
            this.visota = visota;
            this.storona = storona;
        }
        public double GetVisota()
        {
            return this.visota;
        }
        public double GetStorona()
        {
            return this.storona;
        }
        public double CalculateArea()
        {
            double s = (visota * storona) / 2;
            return s;
        }
        
    }
}
