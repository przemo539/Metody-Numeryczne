using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class interpolacjaWielomianowa
    {
        Data dane;
        public interpolacjaWielomianowa(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            bool step1 =  (dane.SizeOfPoints() == 3) ? true : false;
            double w = dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(1).X + dane.getPoint(0).X * dane.getPoint(2).X * dane.getPoint(2).X + dane.getPoint(1).X * dane.getPoint(1).X * dane.getPoint(2).X - dane.getPoint(1).X * dane.getPoint(2).X * dane.getPoint(2).X - dane.getPoint(0).X * dane.getPoint(1).X * dane.getPoint(1).X - dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(2).X;
            bool step2 = (w != 0) ? true : false;
            return (step1 && step2 && !Double.IsNaN(dane.GettoFind()));
        }
        public double Calculate()
        {
            double w = dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(1).X + dane.getPoint(0).X * dane.getPoint(2).X * dane.getPoint(2).X + dane.getPoint(1).X * dane.getPoint(1).X * dane.getPoint(2).X - dane.getPoint(1).X * dane.getPoint(2).X * dane.getPoint(2).X - dane.getPoint(0).X * dane.getPoint(1).X * dane.getPoint(1).X - dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(2).X;
            double wX = dane.getPoint(0).Y * dane.getPoint(1).X + dane.getPoint(0).X * dane.getPoint(2).Y + dane.getPoint(1).Y * dane.getPoint(2).X - dane.getPoint(1).X * dane.getPoint(2).Y - dane.getPoint(0).X * dane.getPoint(1).Y - dane.getPoint(0).Y * dane.getPoint(2).X;
            double wY = dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(1).Y + dane.getPoint(0).Y * dane.getPoint(2).X * dane.getPoint(2).X + dane.getPoint(1).X * dane.getPoint(1).X * dane.getPoint(2).Y - dane.getPoint(1).Y * dane.getPoint(2).X * dane.getPoint(2).X - dane.getPoint(0).Y * dane.getPoint(1).X * dane.getPoint(1).X - dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(2).Y;
            double wZ = dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(1).X* dane.getPoint(2).Y + dane.getPoint(0).X * dane.getPoint(1).Y * dane.getPoint(2).X * dane.getPoint(2).X + dane.getPoint(0).Y*dane.getPoint(1).X * dane.getPoint(1).X * dane.getPoint(2).X - dane.getPoint(0).Y* dane.getPoint(1).X * dane.getPoint(2).X * dane.getPoint(2).X - dane.getPoint(0).X * dane.getPoint(1).X * dane.getPoint(1).X* dane.getPoint(2).Y - dane.getPoint(0).X * dane.getPoint(0).X * dane.getPoint(1).Y* dane.getPoint(2).X;
            //Console.WriteLine((wX / w).ToString() + "x^2 + "+(wY / w).ToString()+"x + "+ (wZ / w).ToString());     
            return ((wX / w)*dane.GettoFind()*dane.GettoFind()+(wY / w)* dane.GettoFind()+ (wZ / w));
        }
    }
}
