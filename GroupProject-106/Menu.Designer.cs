namespace GroupProject_106
{
    partial class Menu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 279);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Green;
            button3.Location = new Point(655, 152);
            button3.Name = "button3";
            button3.Size = new Size(75, 74);
            button3.TabIndex = 3;
            button3.Text = "DEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(655, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 74);
            button2.TabIndex = 2;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(66, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 180);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button14
            // 
            button14.FlatAppearance.BorderColor = Color.Green;
            button14.FlatAppearance.BorderSize = 2;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.Green;
            button14.Location = new Point(396, 129);
            button14.Name = "button14";
            button14.Size = new Size(75, 33);
            button14.TabIndex = 11;
            button14.Text = "ln";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operation_click;
            // 
            // button13
            // 
            button13.FlatAppearance.BorderColor = Color.Green;
            button13.FlatAppearance.BorderSize = 2;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.Green;
            button13.Location = new Point(396, 75);
            button13.Name = "button13";
            button13.Size = new Size(75, 33);
            button13.TabIndex = 10;
            button13.Text = "log";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Operation_click;
            // 
            // button12
            // 
            button12.FlatAppearance.BorderColor = Color.Green;
            button12.FlatAppearance.BorderSize = 2;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.Green;
            button12.Location = new Point(228, 129);
            button12.Name = "button12";
            button12.Size = new Size(75, 33);
            button12.TabIndex = 9;
            button12.Text = "ctg";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Operation_click;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderColor = Color.Green;
            button11.FlatAppearance.BorderSize = 2;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.Green;
            button11.Location = new Point(228, 75);
            button11.Name = "button11";
            button11.Size = new Size(75, 33);
            button11.TabIndex = 8;
            button11.Text = "tan";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Operation_click;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderColor = Color.Green;
            button10.FlatAppearance.BorderSize = 2;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.Green;
            button10.Location = new Point(57, 129);
            button10.Name = "button10";
            button10.Size = new Size(75, 33);
            button10.TabIndex = 7;
            button10.Text = "cos";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Operation_click;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderColor = Color.Green;
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Green;
            button9.Location = new Point(57, 75);
            button9.Name = "button9";
            button9.Size = new Size(75, 33);
            button9.TabIndex = 6;
            button9.Text = "sin";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Operation_click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Green;
            button8.Location = new Point(462, 16);
            button8.Name = "button8";
            button8.Size = new Size(58, 35);
            button8.TabIndex = 5;
            button8.Text = "+/-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Operation_click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Green;
            button7.Location = new Point(384, 16);
            button7.Name = "button7";
            button7.Size = new Size(34, 35);
            button7.TabIndex = 4;
            button7.Text = "^";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Operation_click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Green;
            button6.Location = new Point(302, 16);
            button6.Name = "button6";
            button6.Size = new Size(34, 35);
            button6.TabIndex = 3;
            button6.Text = "/";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Operation_click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(211, 16);
            button5.Name = "button5";
            button5.Size = new Size(34, 35);
            button5.TabIndex = 2;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Operation_click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Green;
            button4.Location = new Point(122, 16);
            button4.Name = "button4";
            button4.Size = new Size(34, 35);
            button4.TabIndex = 1;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Operation_click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(40, 16);
            button1.Name = "button1";
            button1.Size = new Size(34, 35);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Operation_click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            Controls.Add(panel1);
            Name = "Menu";
            Size = new Size(800, 282);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button1;
        private BindingSource bindingSource1;
    }
}
