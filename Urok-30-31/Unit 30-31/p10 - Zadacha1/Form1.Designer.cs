﻿namespace p10___Zadacha1
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 78);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "A=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 78);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "B=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 281);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "flag e";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(198, 181);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 6;
            button1.Text = "ПРОВЕРИ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 408);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
