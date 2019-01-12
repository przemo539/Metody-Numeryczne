namespace NumerkiAplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lagrange_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Polynomial_Button = new System.Windows.Forms.Button();
            this.Newton_button = new System.Windows.Forms.Button();
            this.Answer_Box = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Show_chart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Selected_Common_File = new System.Windows.Forms.RadioButton();
            this.Selected_Without_File = new System.Windows.Forms.RadioButton();
            this.Selected_Separated_File = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Selected_Box = new System.Windows.Forms.RadioButton();
            this.Selected_Without_Box = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Trapezoid_Button = new System.Windows.Forms.Button();
            this.Rectangle_Button = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.MonteCarlo_Button = new System.Windows.Forms.Button();
            this.Simpson_Button = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Gauss_Button = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NewtonRapshon_Button = new System.Windows.Forms.Button();
            this.Bisekcja_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(506, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Załaduj plik";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 166);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.loadFile_DROP);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.loadFile_ENTER);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRZECIĄGNIJ PLIK TUTAJ";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.loadFile_DROP);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.loadFile_ENTER);
            // 
            // Lagrange_button
            // 
            this.Lagrange_button.Location = new System.Drawing.Point(20, 19);
            this.Lagrange_button.Name = "Lagrange_button";
            this.Lagrange_button.Size = new System.Drawing.Size(98, 35);
            this.Lagrange_button.TabIndex = 1;
            this.Lagrange_button.Text = "Lagrange";
            this.Lagrange_button.UseVisualStyleBackColor = true;
            this.Lagrange_button.Click += new System.EventHandler(this.Lagrange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Polynomial_Button);
            this.groupBox2.Controls.Add(this.Newton_button);
            this.groupBox2.Controls.Add(this.Lagrange_button);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interpolacje";
            // 
            // Polynomial_Button
            // 
            this.Polynomial_Button.Location = new System.Drawing.Point(20, 101);
            this.Polynomial_Button.Name = "Polynomial_Button";
            this.Polynomial_Button.Size = new System.Drawing.Size(98, 35);
            this.Polynomial_Button.TabIndex = 6;
            this.Polynomial_Button.Text = "Wielomianowa";
            this.Polynomial_Button.UseVisualStyleBackColor = true;
            this.Polynomial_Button.Click += new System.EventHandler(this.Wielomian_Click);
            // 
            // Newton_button
            // 
            this.Newton_button.Location = new System.Drawing.Point(20, 60);
            this.Newton_button.Name = "Newton_button";
            this.Newton_button.Size = new System.Drawing.Size(98, 35);
            this.Newton_button.TabIndex = 2;
            this.Newton_button.Text = "Newton";
            this.Newton_button.UseVisualStyleBackColor = true;
            this.Newton_button.Click += new System.EventHandler(this.Newton_Click);
            // 
            // Answer_Box
            // 
            this.Answer_Box.Location = new System.Drawing.Point(6, 19);
            this.Answer_Box.Name = "Answer_Box";
            this.Answer_Box.Size = new System.Drawing.Size(372, 262);
            this.Answer_Box.TabIndex = 3;
            this.Answer_Box.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Answer_Box);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 287);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rozwiązania:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Show_chart);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(402, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 287);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metoda Wyswietlana:";
            // 
            // Show_chart
            // 
            this.Show_chart.Location = new System.Drawing.Point(3, 258);
            this.Show_chart.Name = "Show_chart";
            this.Show_chart.Size = new System.Drawing.Size(92, 23);
            this.Show_chart.TabIndex = 7;
            this.Show_chart.Text = "Pokaz wykres";
            this.Show_chart.UseVisualStyleBackColor = true;
            this.Show_chart.Click += new System.EventHandler(this.Show_Chart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Selected_Common_File);
            this.panel3.Controls.Add(this.Selected_Without_File);
            this.panel3.Controls.Add(this.Selected_Separated_File);
            this.panel3.Location = new System.Drawing.Point(3, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 87);
            this.panel3.TabIndex = 6;
            // 
            // Selected_Common_File
            // 
            this.Selected_Common_File.AutoSize = true;
            this.Selected_Common_File.Location = new System.Drawing.Point(3, 12);
            this.Selected_Common_File.Name = "Selected_Common_File";
            this.Selected_Common_File.Size = new System.Drawing.Size(85, 17);
            this.Selected_Common_File.TabIndex = 1;
            this.Selected_Common_File.Text = "Wspolny plik";
            this.Selected_Common_File.UseVisualStyleBackColor = true;
            this.Selected_Common_File.CheckedChanged += new System.EventHandler(this.File_Refresh);
            // 
            // Selected_Without_File
            // 
            this.Selected_Without_File.AutoSize = true;
            this.Selected_Without_File.Checked = true;
            this.Selected_Without_File.Location = new System.Drawing.Point(3, 58);
            this.Selected_Without_File.Name = "Selected_Without_File";
            this.Selected_Without_File.Size = new System.Drawing.Size(76, 17);
            this.Selected_Without_File.TabIndex = 8;
            this.Selected_Without_File.TabStop = true;
            this.Selected_Without_File.Text = "Bez zapisu";
            this.Selected_Without_File.UseVisualStyleBackColor = true;
            this.Selected_Without_File.CheckedChanged += new System.EventHandler(this.File_Refresh);
            // 
            // Selected_Separated_File
            // 
            this.Selected_Separated_File.AutoSize = true;
            this.Selected_Separated_File.Location = new System.Drawing.Point(3, 35);
            this.Selected_Separated_File.Name = "Selected_Separated_File";
            this.Selected_Separated_File.Size = new System.Drawing.Size(93, 17);
            this.Selected_Separated_File.TabIndex = 2;
            this.Selected_Separated_File.Text = "Oddzielne pliki";
            this.Selected_Separated_File.UseVisualStyleBackColor = true;
            this.Selected_Separated_File.CheckedChanged += new System.EventHandler(this.File_Refresh);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Selected_Box);
            this.panel2.Controls.Add(this.Selected_Without_Box);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 71);
            this.panel2.TabIndex = 6;
            // 
            // Selected_Box
            // 
            this.Selected_Box.AutoSize = true;
            this.Selected_Box.Checked = true;
            this.Selected_Box.Location = new System.Drawing.Point(3, 14);
            this.Selected_Box.Name = "Selected_Box";
            this.Selected_Box.Size = new System.Drawing.Size(51, 17);
            this.Selected_Box.TabIndex = 0;
            this.Selected_Box.TabStop = true;
            this.Selected_Box.Text = "Okno";
            this.Selected_Box.UseVisualStyleBackColor = true;
            this.Selected_Box.CheckedChanged += new System.EventHandler(this.AnserBox_Refresh);
            // 
            // Selected_Without_Box
            // 
            this.Selected_Without_Box.AutoSize = true;
            this.Selected_Without_Box.Location = new System.Drawing.Point(3, 37);
            this.Selected_Without_Box.Name = "Selected_Without_Box";
            this.Selected_Without_Box.Size = new System.Drawing.Size(81, 17);
            this.Selected_Without_Box.TabIndex = 7;
            this.Selected_Without_Box.Text = "Nie pokazuj";
            this.Selected_Without_Box.UseVisualStyleBackColor = true;
            this.Selected_Without_Box.CheckedChanged += new System.EventHandler(this.AnserBox_Refresh);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "W programie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "W pliku:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(506, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 95);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pomoc:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(190, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Otwórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Show_Help_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pomocnik tworzenia plików:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Uwaga program jest w stanie rozpoznawać \r\ntylko funkcje wielomianowe!\r\nMozna łado" +
    "wać więcej niż 1 plik naraz!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Trapezoid_Button);
            this.groupBox6.Controls.Add(this.Rectangle_Button);
            this.groupBox6.Location = new System.Drawing.Point(153, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 150);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Całkowanie I";
            // 
            // Trapezoid_Button
            // 
            this.Trapezoid_Button.Location = new System.Drawing.Point(16, 92);
            this.Trapezoid_Button.Name = "Trapezoid_Button";
            this.Trapezoid_Button.Size = new System.Drawing.Size(98, 41);
            this.Trapezoid_Button.TabIndex = 1;
            this.Trapezoid_Button.Text = "Metoda Trapezów";
            this.Trapezoid_Button.UseVisualStyleBackColor = true;
            this.Trapezoid_Button.Click += new System.EventHandler(this.Trapezoid_Click);
            // 
            // Rectangle_Button
            // 
            this.Rectangle_Button.Location = new System.Drawing.Point(16, 29);
            this.Rectangle_Button.Name = "Rectangle_Button";
            this.Rectangle_Button.Size = new System.Drawing.Size(98, 41);
            this.Rectangle_Button.TabIndex = 0;
            this.Rectangle_Button.Text = "Metoda Prostokatów";
            this.Rectangle_Button.UseVisualStyleBackColor = true;
            this.Rectangle_Button.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.MonteCarlo_Button);
            this.groupBox7.Controls.Add(this.Simpson_Button);
            this.groupBox7.Location = new System.Drawing.Point(288, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(129, 150);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Całkowanie II";
            // 
            // MonteCarlo_Button
            // 
            this.MonteCarlo_Button.Location = new System.Drawing.Point(16, 92);
            this.MonteCarlo_Button.Name = "MonteCarlo_Button";
            this.MonteCarlo_Button.Size = new System.Drawing.Size(98, 41);
            this.MonteCarlo_Button.TabIndex = 1;
            this.MonteCarlo_Button.Text = "Metoda\r\nMonte Carlo";
            this.MonteCarlo_Button.UseVisualStyleBackColor = true;
            this.MonteCarlo_Button.Click += new System.EventHandler(this.MonteCarlo_Click);
            // 
            // Simpson_Button
            // 
            this.Simpson_Button.Location = new System.Drawing.Point(16, 29);
            this.Simpson_Button.Name = "Simpson_Button";
            this.Simpson_Button.Size = new System.Drawing.Size(98, 41);
            this.Simpson_Button.TabIndex = 0;
            this.Simpson_Button.Text = "Metoda Simpsona";
            this.Simpson_Button.UseVisualStyleBackColor = true;
            this.Simpson_Button.Click += new System.EventHandler(this.Simpson_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.Gauss_Button);
            this.groupBox8.Location = new System.Drawing.Point(423, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(129, 150);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Równania różnicz.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Metoda RK4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RK4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "Metoda Heuna";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Heun_Click);
            // 
            // Gauss_Button
            // 
            this.Gauss_Button.Location = new System.Drawing.Point(16, 19);
            this.Gauss_Button.Name = "Gauss_Button";
            this.Gauss_Button.Size = new System.Drawing.Size(98, 35);
            this.Gauss_Button.TabIndex = 0;
            this.Gauss_Button.Text = "Metoda Eulera";
            this.Gauss_Button.UseVisualStyleBackColor = true;
            this.Gauss_Button.Click += new System.EventHandler(this.Euler_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NewtonRapshon_Button);
            this.groupBox9.Controls.Add(this.Bisekcja_Button);
            this.groupBox9.Location = new System.Drawing.Point(559, 13);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(129, 150);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Równania nieliniowe";
            // 
            // NewtonRapshon_Button
            // 
            this.NewtonRapshon_Button.Location = new System.Drawing.Point(16, 91);
            this.NewtonRapshon_Button.Name = "NewtonRapshon_Button";
            this.NewtonRapshon_Button.Size = new System.Drawing.Size(98, 41);
            this.NewtonRapshon_Button.TabIndex = 1;
            this.NewtonRapshon_Button.Text = "Metoda\r\nNewton-Rapshon\r\n";
            this.NewtonRapshon_Button.UseVisualStyleBackColor = true;
            this.NewtonRapshon_Button.Click += new System.EventHandler(this.Newton_Raphson_Click);
            // 
            // Bisekcja_Button
            // 
            this.Bisekcja_Button.Location = new System.Drawing.Point(16, 28);
            this.Bisekcja_Button.Name = "Bisekcja_Button";
            this.Bisekcja_Button.Size = new System.Drawing.Size(98, 41);
            this.Bisekcja_Button.TabIndex = 0;
            this.Bisekcja_Button.Text = "Metoda\r\nBisekcji";
            this.Bisekcja_Button.UseVisualStyleBackColor = true;
            this.Bisekcja_Button.Click += new System.EventHandler(this.Bisekcja_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wykresy są generowane tylko dla równań różniczkowych!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kalkulator Numeryczny";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lagrange_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Answer_Box;
        private System.Windows.Forms.Button Newton_button;
        private System.Windows.Forms.Button Polynomial_Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Selected_Without_File;
        private System.Windows.Forms.RadioButton Selected_Without_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Selected_Separated_File;
        private System.Windows.Forms.RadioButton Selected_Common_File;
        private System.Windows.Forms.RadioButton Selected_Box;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Trapezoid_Button;
        private System.Windows.Forms.Button Rectangle_Button;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button MonteCarlo_Button;
        private System.Windows.Forms.Button Simpson_Button;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Gauss_Button;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button NewtonRapshon_Button;
        private System.Windows.Forms.Button Bisekcja_Button;
        private System.Windows.Forms.Button Show_chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

