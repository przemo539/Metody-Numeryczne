using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NumerkiAplikacja
{
    class metodaHeuna
    {
        Data dane;
        public metodaHeuna(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionXY() > 0 && !Double.IsNaN(dane.GetN()) && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()) && dane.SizeOfPoints()>0);
        }
        public void Calculate()
        {
            float xp = (float)dane.GetXp();
            float xk = (float)dane.GetXk();
            float h = (float)dane.GetN();
            int n = (int)((xk - xp) / h);
            float ybuf = dane.getPoint(0).Y;
            float xbuf = dane.getPoint(0).X;
            for (int i = 0; i < n; i++)
            {
                float yn = ybuf + h / 2 * ((float)dane.getFunctionInPointXY(xbuf, ybuf) + (float)dane.getFunctionInPointXY(xbuf + h, ybuf + h * (float)dane.getFunctionInPointXY(xbuf, ybuf)));
                float xn = xbuf + h;
                PointF bufor = new PointF(xn, yn);
                dane.AddPoint(bufor);
               // Console.WriteLine(xn+": "+ yn );
                xbuf = xn;
                ybuf = yn;
            }
            dane.SetDrawable();
        }
    }
}
