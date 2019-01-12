using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerkiAplikacja
{
    class metodaRK4
    {
        Data dane;
        public metodaRK4(Data data)
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
                float x1 = xbuf + h;
                float k1 = h * (float)dane.getFunctionInPointXY(xbuf, ybuf);
                float k2 = h * (float)dane.getFunctionInPointXY(xbuf + h/2, k1/2 + ybuf);
                float k3 = h * (float)dane.getFunctionInPointXY(xbuf + h/2, k2/2 + ybuf);
                float k4 = h * (float)dane.getFunctionInPointXY(xbuf + h, k3 + ybuf);
                float y1 = ybuf + (k1 + 2*k2 + 2*k3 + k4) / 6;
                PointF bufor = new PointF(x1, y1);
                dane.AddPoint(bufor);
               // Console.WriteLine(x1 + ": " + y1);
                xbuf = x1;
                ybuf = y1;
            }
            dane.SetDrawable();
        }
    }
}
