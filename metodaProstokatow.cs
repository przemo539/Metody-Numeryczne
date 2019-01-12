using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class metodaProstokatow
    {
        Data dane;
        public metodaProstokatow(Data data)
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
            for (double i = (Xp + dx); i <= Xk; i += dx)
            {
                wynik += dane.getFunctionInPointX(i);
            }
            return dx * wynik;
        }
    }
}
