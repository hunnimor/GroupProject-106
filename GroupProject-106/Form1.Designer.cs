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
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBoxIntegral = new TextBox();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            panel10 = new Panel();
            panel7 = new Panel();
            button8 = new Button();
            panel9 = new Panel();
            panel8 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            оНасToolStripMenuItem = new ToolStripMenuItem();
            оКалькулятореToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            анекдотПроИнтегралToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6, 6, 6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 213);
            panel2.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxIntegral);
            panel1.Controls.Add(textBoxMin);
            panel1.Controls.Add(textBoxMax);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 58);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 205);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.HotPink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(1328, 36);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(110, 126);
            button1.TabIndex = 5;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ResButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(1233, 66);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 72);
            label2.TabIndex = 4;
            label2.Text = "dx";
            // 
            // textBoxIntegral
            // 
            textBoxIntegral.BorderStyle = BorderStyle.FixedSingle;
            textBoxIntegral.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIntegral.ForeColor = Color.Green;
            textBoxIntegral.Location = new Point(215, 68);
            textBoxIntegral.Margin = new Padding(6, 6, 6, 6);
            textBoxIntegral.Name = "textBoxIntegral";
            textBoxIntegral.Size = new Size(1005, 64);
            textBoxIntegral.TabIndex = 3;
            textBoxIntegral.TextChanged += textBoxIntegral_TextChanged_1;
            // 
            // textBoxMin
            // 
            textBoxMin.ForeColor = Color.Green;
            textBoxMin.Location = new Point(71, 113);
            textBoxMin.Margin = new Padding(6, 6, 6, 6);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(63, 39);
            textBoxMin.TabIndex = 2;
            textBoxMin.KeyPress += textBoxMin_KeyPress;
            // 
            // textBoxMax
            // 
            textBoxMax.ForeColor = Color.Green;
            textBoxMax.Location = new Point(71, 28);
            textBoxMax.Margin = new Padding(6, 6, 6, 6);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(63, 39);
            textBoxMax.TabIndex = 1;
            textBoxMax.KeyPress += textBoxMax_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(124, 2);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 142);
            label1.TabIndex = 0;
            label1.Text = "∫";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(menuStrip1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(6, 4, 6, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1515, 964);
            panel3.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.HotPink;
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 252);
            panel6.Margin = new Padding(6, 6, 6, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(1486, 713);
            panel6.TabIndex = 14;
            panel6.Paint += panel6_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.HotPink;
            panel10.Location = new Point(0, 111);
            panel10.Margin = new Padding(6, 6, 6, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(1486, 602);
            panel10.TabIndex = 1;
            panel10.Paint += panel10_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(button8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button7);
            panel7.Controls.Add(button6);
            panel7.Controls.Add(button5);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(6, 6, 6, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(1486, 113);
            panel7.TabIndex = 0;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Green;
            button8.Location = new Point(386, 6);
            button8.Margin = new Padding(6, 6, 6, 6);
            button8.Name = "button8";
            button8.Size = new Size(305, 128);
            button8.TabIndex = 3;
            button8.Text = "История";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel9
            // 
            panel9.Location = new Point(6, 126);
            panel9.Margin = new Padding(6, 6, 6, 6);
            panel9.Name = "panel9";
            panel9.Size = new Size(1486, 574);
            panel9.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Location = new Point(0, 126);
            panel8.Margin = new Padding(6, 6, 6, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(1486, 574);
            panel8.TabIndex = 1;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Green;
            button7.Location = new Point(1070, 6);
            button7.Margin = new Padding(6, 6, 6, 6);
            button7.Name = "button7";
            button7.Size = new Size(416, 128);
            button7.TabIndex = 2;
            button7.Text = "Результат";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Green;
            button6.Location = new Point(702, 6);
            button6.Margin = new Padding(6, 6, 6, 6);
            button6.Name = "button6";
            button6.Size = new Size(357, 128);
            button6.TabIndex = 1;
            button6.Text = "Константы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Magenta;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(0, 6);
            button5.Margin = new Padding(6, 6, 6, 6);
            button5.Name = "button5";
            button5.Size = new Size(375, 128);
            button5.TabIndex = 0;
            button5.Text = "Меню";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оНасToolStripMenuItem, оКалькулятореToolStripMenuItem, справкаToolStripMenuItem, анекдотПроИнтегралToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1515, 40);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // оНасToolStripMenuItem
            // 
            оНасToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            оНасToolStripMenuItem.ForeColor = Color.HotPink;
            оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            оНасToolStripMenuItem.Size = new Size(96, 36);
            оНасToolStripMenuItem.Text = "О нас";
            оНасToolStripMenuItem.Click += оНасToolStripMenuItem_Click;
            // 
            // оКалькулятореToolStripMenuItem
            // 
            оКалькулятореToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            оКалькулятореToolStripMenuItem.ForeColor = Color.HotPink;
            оКалькулятореToolStripMenuItem.Name = "оКалькулятореToolStripMenuItem";
            оКалькулятореToolStripMenuItem.Size = new Size(208, 36);
            оКалькулятореToolStripMenuItem.Text = "О калькуляторе";
            оКалькулятореToolStripMenuItem.Click += оКалькулятореToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            справкаToolStripMenuItem.ForeColor = Color.HotPink;
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(126, 36);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // анекдотПроИнтегралToolStripMenuItem
            // 
            анекдотПроИнтегралToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            анекдотПроИнтегралToolStripMenuItem.ForeColor = Color.HotPink;
            анекдотПроИнтегралToolStripMenuItem.Name = "анекдотПроИнтегралToolStripMenuItem";
            анекдотПроИнтегралToolStripMenuItem.Size = new Size(280, 36);
            анекдотПроИнтегралToolStripMenuItem.Text = "Анекдот про интеграл";
            анекдотПроИнтегралToolStripMenuItem.Click += анекдотПроИнтегралToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 50);
            panel4.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(530, 2);
            button4.Name = "button4";
            button4.Size = new Size(267, 47);
            button4.TabIndex = 2;
            button4.Text = "Результат";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(264, 3);
            button3.Name = "button3";
            button3.Size = new Size(271, 47);
            button3.TabIndex = 1;
            button3.Text = "Константы";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(258, 47);
            button2.TabIndex = 0;
            button2.Text = "Меню";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 269);
            panel5.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1486, 960);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integral Calcultor by Pibimpap team";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оНасToolStripMenuItem;
        private ToolStripMenuItem оКалькулятореToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem анекдотПроИнтегралToolStripMenuItem;
        private DataGridViewTextBoxColumn zna4;
        private Panel panel5;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        public TextBox textBoxIntegral;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Panel panel9;
        private Panel panel10;
        private Button button8;
    }
}