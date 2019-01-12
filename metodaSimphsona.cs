using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class metodaSimphsona
    {
        Data dane;
        public metodaSimphsona(Data data)
        {
            dane = data;
        }

        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionX() > 0 && !Double.IsNaN(dane.GetN()) && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()));
        }

        public double Calculate()
        {
            double wynik = 0.0;
            double h = (dane.GetXk() - dane.GetXp()) / dane.GetN();
            for (double i = dane.GetXp(); i < dane.GetXk(); i += 2 * h)
            {
                wynik += (dane.getFunctionInPointX(i) + 4 * dane.getFunctionInPointX(i + h) + dane.getFunctionInPointX(i + 2 * h)) * (h / 3);
            }
            return wynik;
        }
    }
}
