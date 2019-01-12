using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class interpolacjaNewtona
    {
        Data dane;
        List<List<double>> rzad;
        public interpolacjaNewtona(Data data)
        {
            dane = data;
            rzad = new List<List<double>>();
        }
        private void GenerateRow()
        {
            int liczbaPunktow = dane.SizeOfPoints();
            List<double> bufor = new List<double>();
            for (int i = 1; i < liczbaPunktow; i++)
            {                
                double wynik =  (dane.getPoint(i).Y - dane.getPoint(i - 1).Y) / (dane.getPoint(i).X - dane.getPoint(i - 1).X);
                bufor.Add(wynik);                
            }
            rzad.Add(bufor);
            int punktow_bufor = liczbaPunktow - 1;
            for (int j = 1; j < liczbaPunktow-1; j++)
            {
                bufor = new List<double>();
                for (int i = 1; i < punktow_bufor; i++)
                {
                    double wynik = (rzad[j - 1][i] - rzad[j-1][i - 1]) / (dane.getPoint(i + j).X - dane.getPoint(i - 1).X);
                    bufor.Add(wynik);
                }
                punktow_bufor--;
                rzad.Add(bufor);
            }
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfPoints() > 0 && !Double.IsNaN(dane.GettoFind()));
        }

        public double Calculate()
        {
            GenerateRow();
            double wynik = dane.getPoint(0).Y;
            double toFind = dane.GettoFind();
            int sizeOfRzad = rzad.Count();


            for (int i = 0; i < sizeOfRzad; i++)
            {
                double bufor = 1;
                for (int j = 0; j <= i; j++)
                {
                    bufor *= (toFind - dane.getPoint(j).X);
                    
                }
                
                wynik += rzad[i][0] * bufor;
            }
            return wynik;
        }
    }
}
