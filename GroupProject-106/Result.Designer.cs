namespace GroupProject_106
{
    partial class Result
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
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxTime = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxTime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 602);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Green;
            label8.Location = new Point(470, 35);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(973, 32);
            label8.TabIndex = 5;
            label8.Text = "*константы, которым не было присвоено значение, по умолчанию принимаются за 0";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(32, 73);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1411, 277);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(29, 30);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 72);
            label7.TabIndex = 5;
            label7.Text = "min";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(21, 147);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 72);
            label6.TabIndex = 4;
            label6.Text = "max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(65, 147);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 54);
            label5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(65, 45);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 54);
            label4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(95, 17);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 177);
            label3.TabIndex = 1;
            label3.Text = "∫";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(228, 79);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 106);
            label2.TabIndex = 0;
            label2.Text = "Result";
            label2.Click += label2_Click;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.HotPink;
            textBoxTime.BorderStyle = BorderStyle.None;
            textBoxTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTime.ForeColor = Color.White;
            textBoxTime.Location = new Point(605, 439);
            textBoxTime.Margin = new Padding(6);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(134, 64);
            textBoxTime.TabIndex = 3;
            textBoxTime.Text = "0.0";
            textBoxTime.TextChanged += textBoxTime_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 439);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(596, 65);
            label1.TabIndex = 2;
            label1.Tag = "";
            label1.Text = "Время выполнения(мс):";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Green;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.HotPink;
            button1.Location = new Point(750, 399);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(693, 149);
            button1.TabIndex = 1;
            button1.Text = "Нарисовать график";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "Result";
            Size = new Size(1486, 602);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxTime;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
    }
}
