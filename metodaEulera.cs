using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerkiAplikacja
{
    class metodaEulera
    {
        Data dane;
        public metodaEulera(Data data)
        {
            dane = data;
        }
        public bool IsCalculated()
        {
            return (dane.SizeOfFunctionXY()>0 && !Double.IsNaN(dane.GetN()) && !Double.IsNaN(dane.GetXp()) && !Double.IsNaN(dane.GetXk()) && dane.SizeOfPoints()>0);
        }
        public void Calculate()
        {
            float xp = (float)dane.GetXp();
            float xk = (float)dane.GetXk();
            float h = (float)dane.GetN();
            int n = (int)((xk - xp) / h);
 
            int iterator = 0;
            float y_temp = dane.getPoint(0).Y;
            for (float i = xp; i < xk; i += h)
            {
                float y1 = y_temp + h * (float)dane.getFunctionInPointXY(i, y_temp);
                PointF bufor = new PointF(i + h, y1);
                dane.AddPoint(bufor);
                //Console.WriteLine((i + h).ToString()+"   "+y1);
                y_temp = y1;
                iterator++;
            }
            dane.SetDrawable();
        }
    }
}
