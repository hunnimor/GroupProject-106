namespace GroupProject_106
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            button1 = new Button();
            textBoxTime = new TextBox();
            textBoxResult = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            panel1 = new Panel();
            textBoxIntegral = new TextBox();
            panel4 = new Panel();
            buttonSin = new Button();
            button17 = new Button();
            buttonCLR = new Button();
            buttonE = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonPi = new Button();
            buttonUmnoj = new Button();
            buttonLn = new Button();
            buttonDel = new Button();
            buttonLog = new Button();
            buttonStepen = new Button();
            buttonCtg = new Button();
            buttonSqrt = new Button();
            buttonTg = new Button();
            buttonCos = new Button();
            textBox6 = new TextBox();
            buttonResult = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            оНасToolStripMenuItem = new ToolStripMenuItem();
            оКалькулятореToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            анекдотПроИнтегралToolStripMenuItem = new ToolStripMenuItem();
            неНажиматьToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxTime);
            panel2.Controls.Add(textBoxResult);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox5);
            panel2.Location = new Point(28, 417);
            panel2.Name = "panel2";
            panel2.Size = new Size(1509, 218);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(798, 41);
            button1.Name = "button1";
            button1.Size = new Size(639, 142);
            button1.TabIndex = 5;
            button1.Text = "Нарисовать график";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.White;
            textBoxTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxTime.Location = new Point(336, 144);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(326, 39);
            textBoxTime.TabIndex = 4;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.White;
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Location = new Point(130, 98);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(532, 39);
            textBoxResult.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(23, 147);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(281, 35);
            textBox8.TabIndex = 2;
            textBox8.Text = "Время вычисления:";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(23, 102);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(176, 35);
            textBox7.TabIndex = 1;
            textBox7.Text = "Ответ:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(20, 19);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(536, 72);
            textBox5.TabIndex = 0;
            textBox5.Text = "Результат";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxIntegral);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(buttonResult);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxMax);
            panel1.Controls.Add(textBoxMin);
            panel1.Location = new Point(28, 57);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 337);
            panel1.TabIndex = 10;
            // 
            // textBoxIntegral
            // 
            textBoxIntegral.BackColor = SystemColors.Window;
            textBoxIntegral.BorderStyle = BorderStyle.FixedSingle;
            textBoxIntegral.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIntegral.Location = new Point(102, 163);
            textBoxIntegral.Margin = new Padding(3, 2, 3, 2);
            textBoxIntegral.Name = "textBoxIntegral";
            textBoxIntegral.Size = new Size(1200, 78);
            textBoxIntegral.TabIndex = 6;
            textBoxIntegral.TextChanged += textBoxIntegral_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(buttonSin);
            panel4.Controls.Add(button17);
            panel4.Controls.Add(buttonCLR);
            panel4.Controls.Add(buttonE);
            panel4.Controls.Add(buttonPlus);
            panel4.Controls.Add(buttonMinus);
            panel4.Controls.Add(buttonPi);
            panel4.Controls.Add(buttonUmnoj);
            panel4.Controls.Add(buttonLn);
            panel4.Controls.Add(buttonDel);
            panel4.Controls.Add(buttonLog);
            panel4.Controls.Add(buttonStepen);
            panel4.Controls.Add(buttonCtg);
            panel4.Controls.Add(buttonSqrt);
            panel4.Controls.Add(buttonTg);
            panel4.Controls.Add(buttonCos);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(109, 248);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1193, 67);
            panel4.TabIndex = 26;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = Color.White;
            buttonSin.FlatStyle = FlatStyle.Popup;
            buttonSin.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSin.ForeColor = SystemColors.ActiveCaptionText;
            buttonSin.Location = new Point(497, 8);
            buttonSin.Margin = new Padding(6);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(65, 50);
            buttonSin.TabIndex = 18;
            buttonSin.Text = "sin";
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Click += buttonSin_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.White;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.ActiveCaptionText;
            button17.Location = new Point(1030, 8);
            button17.Margin = new Padding(6);
            button17.Name = "button17";
            button17.Size = new Size(150, 50);
            button17.TabIndex = 25;
            button17.Text = "Add Const";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // buttonCLR
            // 
            buttonCLR.BackColor = Color.White;
            buttonCLR.FlatStyle = FlatStyle.Popup;
            buttonCLR.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCLR.ForeColor = SystemColors.ActiveCaptionText;
            buttonCLR.Location = new Point(6, 8);
            buttonCLR.Margin = new Padding(6);
            buttonCLR.Name = "buttonCLR";
            buttonCLR.Size = new Size(89, 50);
            buttonCLR.TabIndex = 10;
            buttonCLR.Text = "CLR";
            buttonCLR.UseVisualStyleBackColor = false;
            buttonCLR.Click += buttonCLR_Click;
            // 
            // buttonE
            // 
            buttonE.BackColor = Color.White;
            buttonE.FlatStyle = FlatStyle.Popup;
            buttonE.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonE.ForeColor = SystemColors.ActiveCaptionText;
            buttonE.Location = new Point(954, 8);
            buttonE.Margin = new Padding(6);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(65, 50);
            buttonE.TabIndex = 24;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = false;
            buttonE.Click += buttonE_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.White;
            buttonPlus.FlatStyle = FlatStyle.Popup;
            buttonPlus.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlus.ForeColor = SystemColors.ActiveCaptionText;
            buttonPlus.Location = new Point(109, 8);
            buttonPlus.Margin = new Padding(6);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(41, 50);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.White;
            buttonMinus.FlatStyle = FlatStyle.Popup;
            buttonMinus.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinus.ForeColor = SystemColors.ActiveCaptionText;
            buttonMinus.Location = new Point(161, 8);
            buttonMinus.Margin = new Padding(6);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(41, 50);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPi
            // 
            buttonPi.BackColor = Color.White;
            buttonPi.FlatStyle = FlatStyle.Popup;
            buttonPi.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPi.ForeColor = SystemColors.ActiveCaptionText;
            buttonPi.Location = new Point(876, 8);
            buttonPi.Margin = new Padding(6);
            buttonPi.Name = "buttonPi";
            buttonPi.Size = new Size(65, 50);
            buttonPi.TabIndex = 23;
            buttonPi.Text = "π";
            buttonPi.UseVisualStyleBackColor = false;
            buttonPi.Click += buttonPi_Click;
            // 
            // buttonUmnoj
            // 
            buttonUmnoj.BackColor = Color.White;
            buttonUmnoj.FlatStyle = FlatStyle.Popup;
            buttonUmnoj.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUmnoj.ForeColor = SystemColors.ActiveCaptionText;
            buttonUmnoj.Location = new Point(213, 8);
            buttonUmnoj.Margin = new Padding(6);
            buttonUmnoj.Name = "buttonUmnoj";
            buttonUmnoj.Size = new Size(41, 50);
            buttonUmnoj.TabIndex = 13;
            buttonUmnoj.Text = "x";
            buttonUmnoj.UseVisualStyleBackColor = false;
            buttonUmnoj.Click += buttonUmnoj_Click;
            // 
            // buttonLn
            // 
            buttonLn.BackColor = Color.White;
            buttonLn.FlatStyle = FlatStyle.Popup;
            buttonLn.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLn.ForeColor = SystemColors.ActiveCaptionText;
            buttonLn.Location = new Point(801, 8);
            buttonLn.Margin = new Padding(6);
            buttonLn.Name = "buttonLn";
            buttonLn.Size = new Size(65, 50);
            buttonLn.TabIndex = 22;
            buttonLn.Text = "ln";
            buttonLn.UseVisualStyleBackColor = false;
            buttonLn.Click += buttonLn_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.White;
            buttonDel.FlatStyle = FlatStyle.Popup;
            buttonDel.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDel.ForeColor = SystemColors.ActiveCaptionText;
            buttonDel.Location = new Point(265, 8);
            buttonDel.Margin = new Padding(6);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(41, 50);
            buttonDel.TabIndex = 14;
            buttonDel.Text = "/";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = Color.White;
            buttonLog.FlatStyle = FlatStyle.Popup;
            buttonLog.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLog.ForeColor = SystemColors.ActiveCaptionText;
            buttonLog.Location = new Point(725, 8);
            buttonLog.Margin = new Padding(6);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(65, 50);
            buttonLog.TabIndex = 21;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += buttonLog_Click;
            // 
            // buttonStepen
            // 
            buttonStepen.BackColor = Color.White;
            buttonStepen.FlatStyle = FlatStyle.Popup;
            buttonStepen.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStepen.ForeColor = SystemColors.ActiveCaptionText;
            buttonStepen.Location = new Point(317, 8);
            buttonStepen.Margin = new Padding(6);
            buttonStepen.Name = "buttonStepen";
            buttonStepen.Size = new Size(41, 50);
            buttonStepen.TabIndex = 15;
            buttonStepen.Text = "^";
            buttonStepen.UseVisualStyleBackColor = false;
            buttonStepen.Click += buttonStepen_Click;
            // 
            // buttonCtg
            // 
            buttonCtg.BackColor = Color.White;
            buttonCtg.FlatStyle = FlatStyle.Popup;
            buttonCtg.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCtg.ForeColor = SystemColors.ActiveCaptionText;
            buttonCtg.Location = new Point(648, 8);
            buttonCtg.Margin = new Padding(6);
            buttonCtg.Name = "buttonCtg";
            buttonCtg.Size = new Size(65, 50);
            buttonCtg.TabIndex = 20;
            buttonCtg.Text = "ctg";
            buttonCtg.UseVisualStyleBackColor = false;
            buttonCtg.Click += buttonCtg_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.BackColor = Color.White;
            buttonSqrt.FlatStyle = FlatStyle.Popup;
            buttonSqrt.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSqrt.ForeColor = SystemColors.ActiveCaptionText;
            buttonSqrt.Location = new Point(369, 8);
            buttonSqrt.Margin = new Padding(6);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(41, 50);
            buttonSqrt.TabIndex = 16;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonTg
            // 
            buttonTg.BackColor = Color.White;
            buttonTg.FlatStyle = FlatStyle.Popup;
            buttonTg.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTg.ForeColor = SystemColors.ActiveCaptionText;
            buttonTg.Location = new Point(572, 8);
            buttonTg.Margin = new Padding(6);
            buttonTg.Name = "buttonTg";
            buttonTg.Size = new Size(65, 50);
            buttonTg.TabIndex = 19;
            buttonTg.Text = "tg";
            buttonTg.UseVisualStyleBackColor = false;
            buttonTg.Click += buttonTg_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = Color.White;
            buttonCos.FlatStyle = FlatStyle.Popup;
            buttonCos.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCos.ForeColor = SystemColors.ActiveCaptionText;
            buttonCos.Location = new Point(421, 8);
            buttonCos.Margin = new Padding(6);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(65, 50);
            buttonCos.TabIndex = 17;
            buttonCos.Text = "cos";
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Click += buttonCos_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(20, 13);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(536, 72);
            textBox6.TabIndex = 27;
            textBox6.Text = "Интеграл";
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.White;
            buttonResult.BackgroundImageLayout = ImageLayout.Zoom;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResult.ForeColor = SystemColors.ActiveCaptionText;
            buttonResult.ImageAlign = ContentAlignment.TopLeft;
            buttonResult.Location = new Point(1375, 163);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(124, 83);
            buttonResult.TabIndex = 26;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(1303, 163);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(80, 71);
            textBox4.TabIndex = 7;
            textBox4.Text = "dx";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_integral_64;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 138);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 134);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBoxMax
            // 
            textBoxMax.BorderStyle = BorderStyle.FixedSingle;
            textBoxMax.Location = new Point(65, 93);
            textBoxMax.Margin = new Padding(0);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(67, 39);
            textBoxMax.TabIndex = 4;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            textBoxMax.KeyPress += textBoxMax_KeyPress;
            // 
            // textBoxMin
            // 
            textBoxMin.BorderStyle = BorderStyle.FixedSingle;
            textBoxMin.Location = new Point(26, 275);
            textBoxMin.Margin = new Padding(3, 2, 3, 2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(67, 39);
            textBoxMin.TabIndex = 5;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            textBoxMin.KeyPress += textBoxMin_KeyPress;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(menuStrip1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1921, 840);
            panel3.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оНасToolStripMenuItem, оКалькулятореToolStripMenuItem, справкаToolStripMenuItem, анекдотПроИнтегралToolStripMenuItem, неНажиматьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1921, 42);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // оНасToolStripMenuItem
            // 
            оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            оНасToolStripMenuItem.Size = new Size(96, 38);
            оНасToolStripMenuItem.Text = "О нас";
            оНасToolStripMenuItem.Click += оНасToolStripMenuItem_Click;
            // 
            // оКалькулятореToolStripMenuItem
            // 
            оКалькулятореToolStripMenuItem.Name = "оКалькулятореToolStripMenuItem";
            оКалькулятореToolStripMenuItem.Size = new Size(208, 38);
            оКалькулятореToolStripMenuItem.Text = "О калькуляторе";
            оКалькулятореToolStripMenuItem.Click += оКалькулятореToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(126, 38);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // анекдотПроИнтегралToolStripMenuItem
            // 
            анекдотПроИнтегралToolStripMenuItem.Name = "анекдотПроИнтегралToolStripMenuItem";
            анекдотПроИнтегралToolStripMenuItem.Size = new Size(280, 38);
            анекдотПроИнтегралToolStripMenuItem.Text = "Анекдот про интеграл";
            анекдотПроИнтегралToolStripMenuItem.Click += анекдотПроИнтегралToolStripMenuItem_Click;
            // 
            // неНажиматьToolStripMenuItem
            // 
            неНажиматьToolStripMenuItem.Name = "неНажиматьToolStripMenuItem";
            неНажиматьToolStripMenuItem.Size = new Size(208, 38);
            неНажиматьToolStripMenuItem.Text = "Не нажимать!!!!";
            неНажиматьToolStripMenuItem.Click += неНажиматьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1564, 659);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integral Calcultor by Pibimpap team";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox textBoxTime;
        private TextBox textBoxResult;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private Panel panel1;
        private TextBox textBox6;
        private Button buttonResult;
        public TextBox textBoxIntegral;
        private Button button17;
        private Button buttonE;
        private TextBox textBox4;
        private Button buttonPi;
        private Button buttonLn;
        private Button buttonLog;
        private Button buttonCtg;
        private Button buttonTg;
        private Button buttonSin;
        private Button buttonCos;
        private Button buttonSqrt;
        private Button buttonStepen;
        private Button buttonDel;
        private Button buttonUmnoj;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button buttonCLR;
        private PictureBox pictureBox1;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Panel panel3;
        private Panel panel4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оНасToolStripMenuItem;
        private ToolStripMenuItem оКалькулятореToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem анекдотПроИнтегралToolStripMenuItem;
        private Button button1;
        private DataGridViewTextBoxColumn zna4;
        private ToolStripMenuItem неНажиматьToolStripMenuItem;
    }
}