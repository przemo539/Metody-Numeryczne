using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    public class Data
    {
        public String fileName;
        public String Metoda;
        private List<PointF> Points;
        private List<double> FunctionX;
        private List<double> FunctionY;
        private List<double> Derivative;
        private bool Drawable;
        private double Xk;
        private double Xp;
        private double toFind;
        private double n;
        private double precision;

        public void SetDrawable()
        {
            Drawable = true;
        }
        public bool GetDrawable()
        {
            return Drawable;
        }
        public double GetPrecision()
        {
            return precision;
        }

        public void SetPrecision(double value)
        {
            precision = value;
        }

        public void AddPoint(PointF point)
        {
            Points.Add(point);
        }
        public PointF getPoint(int index)
        {
            if (index < Points.Count())
                return Points[index];
            return new PointF(0,0);
        }
        public double getFunctionInPointX(double x)
        {
            double wynik = 0;
            for (int i = FunctionX.Count()-1; i >= 0; i--)
            {
                wynik += FunctionX[i] * Math.Pow(x, i);
            }
            return wynik;
        }
        public double getDerivativeInPoint(double x)
        {
            double wynik = 0;
            for (int i = Derivative.Count() - 1; i >= 0; i--)
            {
                wynik += Derivative[i] * Math.Pow(x, i);
            }
            return wynik;
        }
        
        public double getFunctionInPointXY(double x, double y)
        {
            double wynik = 0;
            for (int i = FunctionX.Count() - 1; i >= 0; i--)
            {
                wynik += FunctionX[i] * Math.Pow(x, i);
            }
            for (int i = FunctionY.Count() - 1; i >= 0; i--)
            {
                wynik += FunctionY[i] * Math.Pow(y, i);
            }

            return wynik;
        }
        public void AddDerivative(Dictionary<int, double> temporaryFunction, int maxRatio)
        {
            for(int i = 0; i<= maxRatio; i++)
            {
                if (temporaryFunction.ContainsKey(i))
                {
                    Derivative.Add(temporaryFunction[i]);
                }
                else
                {
                    Derivative.Add(0);
                }
            }
            
        }
        public void AddFunctionX(Dictionary<int, double> temporaryFunction, int maxRatio)
        {
            for (int i = 0; i <= maxRatio; i++)
            {
                if (temporaryFunction.ContainsKey(i))
                {
                    FunctionX.Add(temporaryFunction[i]);
                }
                else
                {
                    FunctionX.Add(0);
                }
            }

        }
        public void AddFunctionY(Dictionary<int, double> temporaryFunction, int maxRatio)
        {
            for (int i = 0; i <= maxRatio; i++)
            {
                if (temporaryFunction.ContainsKey(i))
                {
                    FunctionY.Add(temporaryFunction[i]);
                }
                else
                {
                    FunctionY.Add(0);
                }
            }
        }
        public double GetFunctionXRatio(int index)
        {
            if(index < FunctionX.Count())
                return FunctionX[index];
            return 0;
        }
        public void SetFileName(String path)
        {
            fileName = path;
        }
        public void SetXk(double end)
        {
            Xk = end;
        }

        public void SetToFind(double toFinds)
        {
            toFind = toFinds;
        }

        public void SetXp(double start)
        {
            Xp = start;
        }

        public void SetN(double N)
        {
            n = N;
        }
        public double GettoFind()
        {
            return toFind;
        }
        public double GetXk()
        {
            return Xk;
        }
        public String GetFileName()
        {
            return fileName;
        }

        public double GetXp()
        {
           return Xp;
        }
        public double GetN()
        {
            return n;
        }
        public int SizeOfPoints()
        {
            return Points.Count();
        }
        public int SizeOfFunctionX()
        {
            return FunctionX.Count();
        }
        public int SizeOfFunctionXY()
        {
            return FunctionY.Count() + FunctionX.Count();
        }
        public int SizeOfDerivative()
        {
            return Derivative.Count();
        }

        public Data()
        {
            Points = new List<PointF>();
            FunctionX = new List<double>();
            FunctionY = new List<double>();
            Derivative = new List<double>();
            precision = 0.001;
            Drawable = false;
            Xk = Double.NaN;
            Xp = Double.NaN;
            toFind = Double.NaN;
            n = Double.NaN;
        }
    }
}
