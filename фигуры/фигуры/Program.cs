using System;
using System.Collections.Generic;
using System.IO;

namespace фигуры
{
    class Program
    {
        static void CalculateAndShowArea( List <ICalculateArea> ICalculateAreas)
        {
            foreach (var figura in ICalculateAreas)
            {
                Console.WriteLine(figura.CalculateArea());
                Console.WriteLine(figura.Name);
            }

        }
        static public void Initialize()
        {
            //List<ICalculateArea> list1 = new List<ICalculateArea>();
            List<ICalculateArea> list2 = new List<ICalculateArea>();
            using(StreamReader f2 = new StreamReader("input2.txt"))
            {
                string line;
                while ((line = f2.ReadLine()) != null)
                {
                    string[] result = line.Split(" ");
                    string name = result[0];
                    double[] parametrs = new double[result.Length - 1]; 
                    for (int i=1; i<result.Length; i++)
                    {
                        parametrs[i - 1] = Convert.ToDouble(result[i]);
                    }
                    ICalculateArea current;
                    FigyraFactory CurrentFactory=null;
                    switch (name)
                    {
                        case "Kryg":
                            CurrentFactory = new KrugFactory();
                            break;
                        case "Pryamogolnik":
                            CurrentFactory = new PryamoygolnikFactory();
                            break;
                        case "Treygolnik":
                             CurrentFactory = new TreygolnikFactory();
                            break;
                        case "Kvadrat":
                            CurrentFactory = new KvadratFactory();
                            break;
                        case "Trapeciya":
                            CurrentFactory = new KvadratFactory();
                            break;
                    }
                    current = CurrentFactory.Create(name, parametrs);
                    list2.Add(current);
                }
            }
        }
        static void Main(string[] args)
        {
            Treygolnik treygolnik = new Treygolnik(12, 6, "треугольник");
            ICalculateArea figur = new Pryamoygolnik(12, 12, "pryam");
            Kryg kryg = new Kryg("круг", 12);
            Pryamoygolnik pryamoygolnik = new Pryamoygolnik(12, 2, "прямоугольник");
            Trapeciya trapeciya = new Trapeciya(24, 2, 3, "трапеция");
            Kvadrat kvadrat = new Kvadrat(2, 2, "квадрат");
            treygolnik.CalculateArea();
            kryg.CalculateArea();
            pryamoygolnik.CalculateArea();
            trapeciya.CalculateArea();
            kvadrat.CalculateArea();
            List <ICalculateArea> ICalculateAreas = new List<ICalculateArea>();
            ICalculateAreas.Add(treygolnik);
            ICalculateAreas.Add(kryg);
            ICalculateAreas.Add(pryamoygolnik);
            ICalculateAreas.Add(trapeciya);
            ICalculateAreas.Add(kvadrat);
            CalculateAndShowArea(ICalculateAreas);
            Console.ReadLine();
        }
    }
}
