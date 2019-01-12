using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerkiAplikacja
{
    public partial class ShowChart : Form
    {
        List<Data> Datas;
        Random rnd;
        double xk, xp;
        public ShowChart(List<Data> Datas)
        {
            InitializeComponent();
            rnd = new Random();
            this.Datas = Datas ?? throw new ArgumentNullException(nameof(Datas));
            loadChart();
            xk = Double.MinValue;
            xp = Double.MaxValue;
        }
        void loadChart()
        {
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Interval = 0.25;
            chart1.Series.Clear();
            int interator = 0;            
            for (int i = 0; i < Datas.Count(); i++)
            {
                
                if (Datas[i].GetDrawable())
                {
                    chart1.Series.Add(Datas[i].GetFileName()+" - "+Datas[i].Metoda +" id:"+(i+1));
                    for (int j = 0; j < Datas[i].SizeOfPoints(); j++)
                    {
                        if(!Double.IsNaN(Datas[i].getPoint(j).X) && !Double.IsNaN(Datas[i].getPoint(j).Y) && !Double.IsPositiveInfinity(Datas[i].getPoint(j).X) && !Double.IsNegativeInfinity(Datas[i].getPoint(j).X) && !Double.IsPositiveInfinity(Datas[i].getPoint(j).Y) && !Double.IsNegativeInfinity(Datas[i].getPoint(j).Y))
                        chart1.Series[interator].Points.AddXY(Datas[i].getPoint(j).X, Datas[i].getPoint(j).Y);      
                    }
                    chart1.Series[interator].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[interator].BorderWidth = 2;
                    
                    int red = rnd.Next(0, 255);
                    int green = rnd.Next(0, 255);
                    int blue = rnd.Next(0, 255);
                    chart1.Series[interator].Color = Color.FromArgb(red, green, blue);

                    if (xk < Datas[i].GetXk())
                        xk = Datas[i].GetXk();
                    if (xp > Datas[i].GetXp())
                        xp = Datas[i].GetXp();
                    interator++;
                }
            }
            renderFunction();
        }
        void renderFunction()
        {
            chart1.Series.Add("Wartosc obliczona analitycznie");
            int interator = chart1.Series.Count() - 1;
            for(double i = xp;i<2;i+=0.1)
                chart1.Series[interator].Points.AddXY(i, Funct(i));



            chart1.Series[interator].Color = Color.FromArgb(255, 0, 0);
            chart1.Series[interator].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[interator].BorderWidth = 2;
        }
        double Funct(double i)
        {
            //return Math.Exp(2*i);//1
            //return (i*i)/2;//2
            //return Math.Exp(i);//3
            return 2*Math.Exp(i)-i-1;//4
        }
    }
}
