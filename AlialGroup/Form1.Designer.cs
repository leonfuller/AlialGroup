﻿namespace AlialGroup
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Суммарная зарплата\r\n(по департаментам)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Департамент, в котором у сотрудника максимальная зарплата";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Зарплаты руководителей департаментов\r\n(по убыванию)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "С учетом руководителей";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(560, 200);
            this.textBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Вернуться к нструкции";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(600, 440);
            this.Name = "MainForm";
            this.Text = "AlialGroupReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button4;
    }
}
