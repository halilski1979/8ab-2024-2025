namespace P08___CheckRadioButon
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(122, 5);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Изберете пица";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "МАРГАРИТА";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 79);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "БИАНКА";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 118);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "ПЕПЕРОНИ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 24);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Изберет добавки";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Кетчуп";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(34, 81);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(81, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Майонеза";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(34, 106);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(73, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Горчица";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(34, 131);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(64, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Чушки";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 292);
            button1.Name = "button1";
            button1.Size = new Size(378, 54);
            button1.TabIndex = 9;
            button1.Text = "ПОРЪЧАЙ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(30, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 185);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вид пица";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(232, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 185);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "ДОБАВКИ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 355);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "ЦЕНА:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(78, 352);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 35);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 249);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "БРОЙ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 23);
            textBox2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 430);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
    }
}
