using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class metodaMonteCarlo
    {
        Data dane;
        public metodaMonteCarlo(Data data)
        {
            dane = data;
        }

        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionX() > 0 && !Double.IsNaN(dane.GetN()) && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()));
        }

        public double Calculate()
        {
            Random rnd = new Random();
            double fSrednie = 0.0;
            double Xp = dane.GetXp();
            double Xk = dane.GetXk();
            double N = dane.GetN();
            for (int i = 0; i < N; i++)
            {
                double wylosowano = rnd.NextDouble() * (Xk - Xp) + Xp;
                fSrednie += dane.getFunctionInPointX(wylosowano) / N;
            }

            return fSrednie * Math.Abs(Xk - Xp);
        }

    }
}
