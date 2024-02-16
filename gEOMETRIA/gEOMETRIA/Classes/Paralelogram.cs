using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gEOMETRIA.Classes
{
    public class Paralelogram : Chetirehygolnik
    {
        public void SidesCalculationParall()
        {
            sideA = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            sideB = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            sideC = sideA;
            sideD = sideB;
            Console.WriteLine("Стороны paralelogram");
            Console.WriteLine($"Сторона А={Math.Round(sideA, 2)}");
            Console.WriteLine($"Сторона B={Math.Round(sideB, 2)}");
            Console.WriteLine($"Сторона C={Math.Round(sideC, 2)}");
            Console.WriteLine($"Сторона D={Math.Round(sideD, 2)}");
        }

        public double Perimetr()
        {
            double pp = 2 * (sideA+sideB);
            return pp;
        }
        public double ugol()
        {
             double cosa = ((sideA * sideA) + (sideB * sideB) - (diagonal1 * diagonal1)/(2 * sideB * sideA));
            return cosa;
        }
        public double sinugol() 
        {
            double sina = Math.Sqrt(1 - ugol());
            return sina;
        }
        public void Ploshad()
        {
            double s = 0;
            s = sideA * sideB * sinugol();
            Console.WriteLine($"Площадь {s}");
        }
    }
}
