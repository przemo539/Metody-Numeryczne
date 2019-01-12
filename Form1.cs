using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NumerkiAplikacja
{
    public partial class Form1 : Form
    {
        List<Data> Datas;
        bool Answer_Box_Enable;
        int File_Option;
        int iterator;


        public Form1()
        {
            InitializeComponent();
            Datas = new List<Data>();
            Answer_Box_Enable = true;
            File_Option = 0;
        }


        private int TryFindSth(String x, char C)
        {
            int position = x.IndexOf(C);
            if (position == -1)
            {
                return x.Length;
            }
            else
            {
                return position;
            }

        }

        private int TryFindMinus(String x)
        {
            int position = x.IndexOf('-');
            if(position == -1)
            {
                return x.Length;
            }
            else if(position < 2)
            {
                return position;
            }
            else
            {
                if(x.Substring(position-1, 1) == "^")
                {
                    return TryFindMinus(x.Substring(0, position) + "a" + x.Substring(position, x.Length));
                }
                else if(x.Substring(position - 1, 1) == "0" && x.Substring(position - 2, 1) == "^"){
                    return TryFindMinus(x.Substring(0, position) + "a" + x.Substring(position, x.Length));
                }
                return position;
            }
        }

        private void loadFile_DROP(object sender, DragEventArgs e)
        {
            //if (Datas.Count() > 0)
                //Datas.Clear();
            try
            {
                string[] a = (string[])e.Data.GetData(DataFormats.FileDrop, false);
  
                if (a != null)
                {
                for (int i = 0; i < a.Length; i++)
                    {
                        FileStream fs = new FileStream(a.GetValue(i).ToString(),
                        FileMode.Open, FileAccess.Read);

                        try
                        {
                            Data DataBufor = new Data();
                            DataBufor.SetFileName(Path.GetFileName(a.GetValue(i).ToString()));
                            StreamReader sr = new StreamReader(fs);
                            
                            while (!sr.EndOfStream)
                            {
                                String bufor = sr.ReadLine();
                                if (String.IsNullOrEmpty(bufor))
                                    continue;
                              
                                bufor = (bufor.Trim(' ')).ToLower();
                                String[] pociete = bufor.Split('=');
                                pociete[0]=pociete[0].TrimEnd(' ');
                                pociete[1] = pociete[1].Trim(' ');
                              if (pociete[0].Equals("f(x,y)") || pociete[0].Equals("f(x)") || pociete[0].Equals("f'(x)"))
                                {   //Pobieranie funkcji f(x,y), f(x), f'(x)
                                    String BuforujText = pociete[1];
                                    Dictionary<int, double> temporaryFunctionX = new Dictionary<int, double>();
                                    Dictionary<int, double> temporaryFunctionY = new Dictionary<int, double>();
                                    int maxRatioX = -1;
                                    int maxRatioY = -1;
                                    while (!String.IsNullOrEmpty(BuforujText))
                                    {
                                        BuforujText = BuforujText.Trim(' ');
                                        int positionOfMinus = TryFindMinus(BuforujText);
                                        int positionOfPlus = TryFindSth(BuforujText, '+');
                                        int positionOfX = TryFindSth(BuforujText, 'x');
                                        int positionOfY = TryFindSth(BuforujText, 'y');
                                        bool subtract = false;
                                        if (positionOfMinus == 0 || positionOfPlus == 0)
                                        {
                                            BuforujText = BuforujText.Remove(0, 1);
                                            if (positionOfMinus == 0)
                                                subtract = true;
                                            positionOfMinus = TryFindMinus(BuforujText);
                                            positionOfPlus = TryFindSth(BuforujText, '+');
                                        }
                                        String toCut = BuforujText.Substring(0, (positionOfMinus < positionOfPlus) ? positionOfMinus : positionOfPlus);
                                        BuforujText = BuforujText.Remove(0, (positionOfMinus < positionOfPlus) ? positionOfMinus : positionOfPlus);
                                        String[] toOperate;
                                        if (positionOfX <= positionOfY)
                                        {
                                            toOperate = toCut.Split('x');
                                        }
                                        else
                                        {
                                            toOperate = toCut.Split('y');
                                        }

                                        if (toOperate.Length > 1 && !String.IsNullOrEmpty(toOperate[1]))
                                            toOperate[1] = toOperate[1].Remove(toOperate[1].IndexOf('^'), 1);

                                        int temp = (toOperate.Length > 1) ? (String.IsNullOrEmpty(toOperate[1]))?1:int.Parse(toOperate[1].Trim(' ')) : 0;
                                        if (temp > maxRatioX && positionOfX < positionOfY)
                                            maxRatioX = temp;
                                        else if(temp > maxRatioY && positionOfX > positionOfY)
                                            maxRatioY = temp;
                                        if (String.IsNullOrEmpty(toOperate[0]))
                                        {
                                            if (positionOfX <= positionOfY)
                                            {
                                                if (!temporaryFunctionX.ContainsKey(temp))
                                                    temporaryFunctionX.Add(temp, (subtract) ? -1 : 1);
                                            }
                                            else
                                            {
                                                if (!temporaryFunctionY.ContainsKey(temp))
                                                    temporaryFunctionY.Add(temp, (subtract) ? -1 : 1);
                                            }
                                        }
                                        else
                                        {
                                            if (positionOfX <= positionOfY)
                                            {
                                                if (!temporaryFunctionX.ContainsKey(temp))
                                                    temporaryFunctionX.Add(temp, double.Parse((subtract) ? "-" + toOperate[0].Trim(' ') : toOperate[0].Trim(' ')));
                                                else
                                                    temporaryFunctionX[temp] += double.Parse((subtract) ? "-" + toOperate[0].Trim(' ') : toOperate[0].Trim(' '));
                                            }
                                            else
                                            {
                                                if (!temporaryFunctionY.ContainsKey(temp))
                                                    temporaryFunctionY.Add(temp, double.Parse((subtract) ? "-" + toOperate[0].Trim(' ') : toOperate[0].Trim(' ')));
                                                else
                                                    temporaryFunctionY[temp] += double.Parse((subtract) ? "-" + toOperate[0].Trim(' ') : toOperate[0].Trim(' '));
                                            }
                                        }
                                    }
                                    if (!pociete[0].Equals("f'(x)"))
                                    {
                                        DataBufor.AddFunctionX(temporaryFunctionX, maxRatioX);
                                        DataBufor.AddFunctionY(temporaryFunctionY, maxRatioY);
                                    }
                                    else
                                    {
                                        DataBufor.AddDerivative(temporaryFunctionX, maxRatioX);
                                    }
                                        

                                }
                                else if (pociete[1].Equals("?"))
                                {
                                    //Pobieranie wartości szukanej
                                    pociete[0] = (pociete[0].Remove(pociete[0].IndexOf(")"), 1)).Remove(pociete[0].IndexOf("f("), 2);
                                    DataBufor.SetToFind(Double.Parse(pociete[0].Trim(' ')));
;                               }
                                else if (pociete[0].Equals("xk"))
                                {
                                    //Pobranie wartości Xk
                                    DataBufor.SetXk(Double.Parse(pociete[1].Trim(' ')));
                                }
                                else if (pociete[0].Equals("xp"))
                                {
                                    DataBufor.SetXp(Double.Parse(pociete[1].Trim(' ')));
                                    //Pobranie wartości Xp
                                }
                                else if (pociete[0].Equals("n"))
                                {
                                    DataBufor.SetN(Double.Parse(pociete[1].Trim(' ')));
                                    //Pobranie wartości n
                                }
                                else if(pociete[0].Equals("prec"))
                                {
                                    DataBufor.SetPrecision(Double.Parse(pociete[1].Trim(' ')));
                                    //Pobranie wartości Dokładności
                                }
                                else
                                {
                                    //Pobranie punktu
                                    pociete[0] = (pociete[0].Remove(pociete[0].IndexOf(")"), 1)).Remove(pociete[0].IndexOf("f("), 2);
                                    DataBufor.AddPoint(new PointF(float.Parse(pociete[0].Trim(' ')), float.Parse(pociete[1].Trim(' '))));
                                }
                                    
                            }
                            Datas.Add(DataBufor);
                            sr.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Wykryto błąd składni pliku! Sprawdz czy używasz przecinków a nie kropek!");
                            Console.WriteLine(ex.ToString());
                        }
                        fs.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DragDrop function: " + ex.Message);
            }
        }

        private void loadFile_ENTER(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Lagrange_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                interpolacjaLagranga obliczamy = new interpolacjaLagranga(Datas[i]);

                if (obliczamy.IsCalculated())
                {
                    Show_Message("Interpolacja Lagranga", "InterpLagrange", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Interpolacja Lagranga", "InterpLagrange", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void Newton_Click(object sender, EventArgs e)
        {
            for(int i= iterator; i<Datas.Count();i++)
            {

                interpolacjaNewtona obliczamy = new interpolacjaNewtona(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Interpolacja Newtona", "InterpNewtona", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Interpolacja Newtona", "InterpNewtona", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void Wielomian_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                interpolacjaWielomianowa obliczamy = new interpolacjaWielomianowa(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Interpolacja Wielomianowa", "InterpWielomian", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Interpolacja Wielomianowa", "InterpWielomian", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC I POPRAWNOSC DANYCH");
            }
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaProstokatow obliczamy = new metodaProstokatow(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Metoda Prostokatow", "Prostokatow", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Prostokatow", "Prostokatow", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void Trapezoid_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaTrapezow obliczamy = new metodaTrapezow(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Metoda Trapezow", "Trapezow", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Trapezow", "Trapezow", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void Simpson_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaSimphsona obliczamy = new metodaSimphsona(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Metoda Simpson", "Simpson",  Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Simpson", "Simpson", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void MonteCarlo_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaMonteCarlo obliczamy = new metodaMonteCarlo(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Metoda Monte Carlo", "MonteCarlo", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Monte Carlo", "MonteCarlo", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }
        private void Bisekcja_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                bisekcja obliczamy = new bisekcja(Datas[i]);

                if (obliczamy.IsCalculated()) { 
                    Show_Message("Metoda Bisekcji", "Bisekcja", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Bisekcji", "Bisekcja", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }
        private void Newton_Raphson_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                newtonRaphson obliczamy = new newtonRaphson(Datas[i]);


                if (obliczamy.IsCalculated())
                {
                    Show_Message("Metoda Newton-Raphsona", "NewtonRaphson", Datas[i].GetFileName(), obliczamy.Calculate().ToString());
                    iterator++;
                }
                else
                    Show_Message("Metoda Newton-Raphsona", "NewtonRaphson", Datas[i].GetFileName(), "BŁĄD NIE ODNALEZIONO FUNKCJI F(X)!!!!!");
            }
        }
        private void Euler_Click(object sender, EventArgs e)
        {
            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaEulera obliczamy = new metodaEulera(Datas[i]);
                
                if (obliczamy.IsCalculated())
                {
                    obliczamy.Calculate();
                    Show_Message("Metoda Eulera", "Euler", Datas[i].GetFileName(), "WYKRES WYGENEROWANY!");
                    Datas[i].Metoda = "Euler";
                    iterator++;
                }
                else
                    Show_Message("Metoda Eulera", "Euler", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }
        private void Heun_Click(object sender, EventArgs e)
        {

            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaHeuna obliczamy = new metodaHeuna(Datas[i]);
                
                if (obliczamy.IsCalculated())
                {
                    obliczamy.Calculate();
                    Show_Message("Metoda Heuna", "Heun", Datas[i].GetFileName(), "WYKRES WYGENEROWANY!");
                    Datas[i].Metoda = "Heuna";
                    iterator++;
                }
                else
                    Show_Message("Metoda Heuna", "Heun", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }
        private void RK4_Click(object sender, EventArgs e)
        {

            for (int i = iterator; i < Datas.Count(); i++)
            {
                metodaRK4 obliczamy = new metodaRK4(Datas[i]);

                if (obliczamy.IsCalculated())
                {
                    obliczamy.Calculate();
                    Show_Message("Metoda RK4", "RK4", Datas[i].GetFileName(), "WYKRES WYGENEROWANY!");
                    Datas[i].Metoda = "RK4";
                    iterator++;
                }
                else
                    Show_Message("Metoda RK4", "RK4", Datas[i].GetFileName(), "BŁĄD DANYCH WEJSCIOWYCH, SPRAWDZ KOMPLETNOSC DANYCH");
            }
        }

        private void AnserBox_Refresh(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                if(rb.Name == "Selected_Box")
                {
                    Answer_Box_Enable = true;
                }
                else
                {
                    Answer_Box_Enable = false;
                }
            }
        }

        private void File_Refresh(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                if (rb.Name == "Selected_Common_File")
                {
                    File_Option = 2;
                }
                else if (rb.Name == "Selected_Separated_File")
                {
                    File_Option = 1;
                }
                else
                {
                    File_Option = 0;
                }
            }
        }
        private void Show_Message(String metoda, String typ,  String filename, String message)
        {
            if (Answer_Box_Enable)
            {
                Answer_Box.Text += metoda + ": wynik dla " + filename + " wynosi " + message+"\n";
            }


            if (File_Option == 2) //Selected_Common_File
            { 
                Send_To_File(metoda, "SHARED_ANSWER.txt", filename, message);
            }
            else if (File_Option == 1) //Selected_Separated_File
            {
                Send_To_File(metoda, typ, filename, message);
            }
        }
        private void Send_To_File(String metoda, String typ, String filename, String message)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            if (!Directory.Exists(startupPath + "\\ANSWER"))
            {
                Directory.CreateDirectory(startupPath + "\\ANSWER");
            }
            FileInfo File_Info = new FileInfo(startupPath + "\\ANSWER\\" + typ +".txt");
            FileStream Shared_File = new FileStream(startupPath + "\\ANSWER\\" + typ + ".txt", FileMode.Append, FileAccess.Write);

            try
            {
                StreamWriter sw = new StreamWriter(Shared_File);
                if (File_Info.LastWriteTime.ToShortDateString() != DateTime.Now.ToString("yyyy/MM/d") || Shared_File.Position == 0)
                {
                    sw.WriteLine("////////////////////////////////////  " + DateTime.Now.ToString("yyyy/MM/d") + "  ////////////////////////////////////");
                }
                sw.WriteLine(metoda + ": wynik dla " + filename + " wynosi " + message + "\n");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Show_Chart_Click(object sender, EventArgs e)
        {
            ShowChart ChartGenerator = new ShowChart(Datas);

            ChartGenerator.ShowDialog();
        }
        private void Show_Help_Click(object sender, EventArgs e)
        {
            Pomoc HelpGenerator = new Pomoc();
            HelpGenerator.ShowDialog();
        }


    }
}
