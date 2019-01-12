using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class newtonRaphson
    {
        Data dane;
        public newtonRaphson(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionX() > 0 && dane.SizeOfDerivative() > 0);
        }
        public double Calculate()
        {
            double x1 = -1;
            double x2 = 1;
            double Precision = dane.GetPrecision();
            do
            {
                x1 = x2;
                x2 = x1 - dane.getFunctionInPointX(x1) / dane.getDerivativeInPoint(x1);
                if (Math.Abs(x2 - x1) <= Precision)
                    break;
                if (Math.Abs(dane.getFunctionInPointX(x1)) <= Precision)
                    break;
            } while (true);
            return Math.Round(x2, 0);
        }
    }
}