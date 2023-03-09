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
            pictureBox1 = new PictureBox();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            textBoxIntegral = new TextBox();
            textBox4 = new TextBox();
            panel1 = new Panel();
            textBox6 = new TextBox();
            buttonResult = new Button();
            button17 = new Button();
            buttonE = new Button();
            buttonPi = new Button();
            buttonLn = new Button();
            buttonLog = new Button();
            buttonCtg = new Button();
            buttonTg = new Button();
            buttonSin = new Button();
            buttonCos = new Button();
            buttonSqrt = new Button();
            buttonStepen = new Button();
            buttonDel = new Button();
            buttonUmnoj = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonCLR = new Button();
            panel2 = new Panel();
            textBoxTime = new TextBox();
            textBoxResult = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBoxFunc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_integral_64;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 133);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 139);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(65, 92);
            textBoxMax.Margin = new Padding(0);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(66, 39);
            textBoxMax.TabIndex = 4;
            textBoxMax.KeyPress += textBoxMax_KeyPress;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(26, 265);
            textBoxMin.Margin = new Padding(4, 2, 4, 2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(66, 39);
            textBoxMin.TabIndex = 5;
            textBoxMin.KeyPress += textBoxMin_KeyPress;
            // 
            // textBoxIntegral
            // 
            textBoxIntegral.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIntegral.Location = new Point(103, 160);
            textBoxIntegral.Margin = new Padding(4, 2, 4, 2);
            textBoxIntegral.Name = "textBoxIntegral";
            textBoxIntegral.Size = new Size(1216, 78);
            textBoxIntegral.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(1304, 163);
            textBox4.Margin = new Padding(4, 2, 4, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(80, 71);
            textBox4.TabIndex = 7;
            textBox4.Text = "dx";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(buttonResult);
            panel1.Controls.Add(textBoxIntegral);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(buttonE);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(buttonPi);
            panel1.Controls.Add(buttonLn);
            panel1.Controls.Add(buttonLog);
            panel1.Controls.Add(buttonCtg);
            panel1.Controls.Add(buttonTg);
            panel1.Controls.Add(buttonSin);
            panel1.Controls.Add(buttonCos);
            panel1.Controls.Add(buttonSqrt);
            panel1.Controls.Add(buttonStepen);
            panel1.Controls.Add(buttonDel);
            panel1.Controls.Add(buttonUmnoj);
            panel1.Controls.Add(buttonMinus);
            panel1.Controls.Add(buttonPlus);
            panel1.Controls.Add(buttonCLR);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxMax);
            panel1.Controls.Add(textBoxMin);
            panel1.Location = new Point(22, 26);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 367);
            panel1.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(19, 13);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(536, 76);
            textBox6.TabIndex = 27;
            textBox6.Text = "Интеграл:";
            // 
            // buttonResult
            // 
            buttonResult.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResult.Location = new Point(1373, 163);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(123, 75);
            buttonResult.TabIndex = 26;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // button17
            // 
            button17.Location = new Point(1145, 223);
            button17.Margin = new Padding(6);
            button17.Name = "button17";
            button17.Size = new Size(149, 49);
            button17.TabIndex = 25;
            button17.Text = "Add Const";
            button17.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            buttonE.Location = new Point(1069, 223);
            buttonE.Margin = new Padding(6);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(65, 49);
            buttonE.TabIndex = 24;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = true;
            buttonE.Click += buttonE_Click;
            // 
            // buttonPi
            // 
            buttonPi.Location = new Point(992, 223);
            buttonPi.Margin = new Padding(6);
            buttonPi.Name = "buttonPi";
            buttonPi.Size = new Size(65, 49);
            buttonPi.TabIndex = 23;
            buttonPi.Text = "π";
            buttonPi.UseVisualStyleBackColor = true;
            buttonPi.Click += buttonPi_Click;
            // 
            // buttonLn
            // 
            buttonLn.Location = new Point(916, 223);
            buttonLn.Margin = new Padding(6);
            buttonLn.Name = "buttonLn";
            buttonLn.Size = new Size(65, 49);
            buttonLn.TabIndex = 22;
            buttonLn.Text = "ln";
            buttonLn.UseVisualStyleBackColor = true;
            buttonLn.Click += buttonLn_Click;
            // 
            // buttonLog
            // 
            buttonLog.Location = new Point(840, 223);
            buttonLog.Margin = new Padding(6);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(65, 49);
            buttonLog.TabIndex = 21;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = true;
            buttonLog.Click += buttonLog_Click;
            // 
            // buttonCtg
            // 
            buttonCtg.Location = new Point(764, 223);
            buttonCtg.Margin = new Padding(6);
            buttonCtg.Name = "buttonCtg";
            buttonCtg.Size = new Size(65, 49);
            buttonCtg.TabIndex = 20;
            buttonCtg.Text = "ctg";
            buttonCtg.UseVisualStyleBackColor = true;
            buttonCtg.Click += buttonCtg_Click;
            // 
            // buttonTg
            // 
            buttonTg.Location = new Point(688, 223);
            buttonTg.Margin = new Padding(6);
            buttonTg.Name = "buttonTg";
            buttonTg.Size = new Size(65, 49);
            buttonTg.TabIndex = 19;
            buttonTg.Text = "tg";
            buttonTg.UseVisualStyleBackColor = true;
            buttonTg.Click += buttonTg_Click;
            // 
            // buttonSin
            // 
            buttonSin.Location = new Point(612, 223);
            buttonSin.Margin = new Padding(6);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(65, 49);
            buttonSin.TabIndex = 18;
            buttonSin.Text = "sin";
            buttonSin.UseVisualStyleBackColor = true;
            buttonSin.Click += buttonSin_Click;
            // 
            // buttonCos
            // 
            buttonCos.Location = new Point(536, 223);
            buttonCos.Margin = new Padding(6);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(65, 49);
            buttonCos.TabIndex = 17;
            buttonCos.Text = "cos";
            buttonCos.UseVisualStyleBackColor = true;
            buttonCos.Click += buttonCos_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Location = new Point(484, 223);
            buttonSqrt.Margin = new Padding(6);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(41, 49);
            buttonSqrt.TabIndex = 16;
            buttonSqrt.Text = "√";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonStepen
            // 
            buttonStepen.Location = new Point(432, 223);
            buttonStepen.Margin = new Padding(6);
            buttonStepen.Name = "buttonStepen";
            buttonStepen.Size = new Size(41, 49);
            buttonStepen.TabIndex = 15;
            buttonStepen.Text = "^";
            buttonStepen.UseVisualStyleBackColor = true;
            buttonStepen.Click += buttonStepen_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(380, 223);
            buttonDel.Margin = new Padding(6);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(41, 49);
            buttonDel.TabIndex = 14;
            buttonDel.Text = "/";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonUmnoj
            // 
            buttonUmnoj.Location = new Point(328, 223);
            buttonUmnoj.Margin = new Padding(6);
            buttonUmnoj.Name = "buttonUmnoj";
            buttonUmnoj.Size = new Size(41, 49);
            buttonUmnoj.TabIndex = 13;
            buttonUmnoj.Text = "x";
            buttonUmnoj.UseVisualStyleBackColor = true;
            buttonUmnoj.Click += buttonUmnoj_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(276, 223);
            buttonMinus.Margin = new Padding(6);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(41, 49);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(224, 223);
            buttonPlus.Margin = new Padding(6);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(41, 49);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonCLR
            // 
            buttonCLR.Location = new Point(123, 223);
            buttonCLR.Margin = new Padding(6);
            buttonCLR.Name = "buttonCLR";
            buttonCLR.Size = new Size(89, 49);
            buttonCLR.TabIndex = 10;
            buttonCLR.Text = "CLR";
            buttonCLR.UseVisualStyleBackColor = true;
            buttonCLR.Click += buttonCLR_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxFunc);
            panel2.Controls.Add(textBoxTime);
            panel2.Controls.Add(textBoxResult);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox5);
            panel2.Location = new Point(25, 412);
            panel2.Name = "panel2";
            panel2.Size = new Size(1523, 242);
            panel2.TabIndex = 11;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = SystemColors.Window;
            textBoxTime.Location = new Point(247, 147);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(326, 39);
            textBoxTime.TabIndex = 4;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Location = new Point(104, 99);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(469, 39);
            textBoxResult.TabIndex = 3;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(23, 147);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(243, 32);
            textBox8.TabIndex = 2;
            textBox8.Text = "Время вычисления:";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(23, 102);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(175, 32);
            textBox7.TabIndex = 1;
            textBox7.Text = "Ответ:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(20, 20);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(536, 76);
            textBox5.TabIndex = 0;
            textBox5.Text = "Результат:";
            // 
            // textBoxFunc
            // 
            textBoxFunc.BackColor = SystemColors.Window;
            textBoxFunc.Location = new Point(562, 33);
            textBoxFunc.Name = "textBoxFunc";
            textBoxFunc.ReadOnly = true;
            textBoxFunc.Size = new Size(469, 39);
            textBoxFunc.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1560, 665);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Integral Calcultor by Pibimpap team";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private TextBox textBox4;
        private Panel panel1;
        private Button button17;
        private Button buttonE;
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
        private Button buttonResult;
        public TextBox textBoxIntegral;
        private TextBox textBox6;
        private Panel panel2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBoxTime;
        private TextBox textBoxResult;
        private TextBox textBoxFunc;
    }
}