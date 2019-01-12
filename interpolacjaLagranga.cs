using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class interpolacjaLagranga
    {
        Data dane;
        public interpolacjaLagranga(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfPoints() > 0 && !Double.IsNaN(dane.GettoFind()));
        }
        public double Calculate()
        {
            double wynik = 0;
            double SizeOfPoints = dane.SizeOfPoints();
            double toFind = dane.GettoFind();
            for (int i = 0; i < SizeOfPoints; i++)
            {
                double Lx = 1;
                for (int j = 0; j < SizeOfPoints; j++)
                {
                    if (i == j) continue;
                    Lx *= (toFind - dane.getPoint(j).X) / (dane.getPoint(i).X - dane.getPoint(j).X);
                }
                wynik +=dane.getPoint(i).Y*Lx;
            }
                return wynik;
        }
    }
}
