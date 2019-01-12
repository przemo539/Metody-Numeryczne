using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class metodaTrapezow
    {
        Data dane;
        public metodaTrapezow(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionX() > 0 && !Double.IsNaN(dane.GetN()) && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()));
        }
        public double Calculate()
        {
            double wynik = 0;
            double Xk = dane.GetXk();
            double Xp = dane.GetXp();
            double dx = (Xk - Xp) / dane.GetN();
            for (double i = Xp; i < Xk; i += dx)
            {
                wynik += (dane.getFunctionInPointX(i) + dane.getFunctionInPointX(i + dx)) * dx / 2.0;
            }
            return wynik;
        }
    }
}

