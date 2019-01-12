using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class bisekcja
    {
        Data dane;
        public bisekcja(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionX() > 0 && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()));
        }
        public double Calculate()
        {
            double x1;
            double Xp = dane.GetXp();
            double Xk = dane.GetXk();
            double Precision = dane.GetPrecision();
            do
            {
                x1 = (Xp + Xk) / 2;
                if (dane.getFunctionInPointX(x1) == 0)
                {
                    return x1;
                }
                if (dane.getFunctionInPointX(x1) * dane.getFunctionInPointX(Xp) < 0)
                {
                    Xk = x1;
                }
                else if (dane.getFunctionInPointX(x1) * dane.getFunctionInPointX(Xk) < 0)
                {
                    Xp = x1;
                }
            } while (Math.Abs(Xp - Xk) > Precision);
            return Math.Round((Xp + Xk)/2, Precision.ToString().Length-2);
            
        }
    }
}
