namespace SystemProgrammingLaba3
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1034, 26);
            button1.Name = "button1";
            button1.Size = new Size(153, 45);
            button1.TabIndex = 0;
            button1.Text = "Parallel.For";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(783, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "20";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(783, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "20";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(26, 158);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(593, 497);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(625, 158);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(562, 497);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(783, 95);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(112, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "2";
            // 
            // button2
            // 
            button2.Location = new Point(1034, 95);
            button2.Name = "button2";
            button2.Size = new Size(153, 45);
            button2.TabIndex = 6;
            button2.Text = "Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Ink Free", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(593, 113);
            label1.TabIndex = 7;
            label1.Text = "Двухмерный массив заполнить случайными значениями в \r\nдиапазоне от 20 до 40. Необходимо отсортировать методом\r\nвставки нечетные столбцы по возрастанию. Количество столбцов\r\nдолжно быть кратно 4.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(652, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 8;
            label2.Text = "Строки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Ink Free", 9F, FontStyle.Bold);
            label3.Location = new Point(652, 62);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 9;
            label3.Text = "Столбцы";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Ink Free", 9F, FontStyle.Bold);
            label4.Location = new Point(652, 95);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 10;
            label4.Text = "Потоки";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1227, 696);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа № 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
