﻿namespace _3x3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.checkBox1 = new System.Windows.Forms.CheckBox();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        	this.pictureBox1.Location = new System.Drawing.Point(2, 64);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(300, 300);
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
        	this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(318, 332);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "Массив";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Visible = false;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(308, 216);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(142, 46);
        	this.button3.TabIndex = 3;
        	this.button3.Text = "Тест позиции";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Visible = false;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// listBox1
        	// 
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.Location = new System.Drawing.Point(476, 64);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(215, 303);
        	this.listBox1.TabIndex = 4;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(83, 35);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 5;
        	this.button2.Text = "вперед";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(2, 35);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(75, 23);
        	this.button4.TabIndex = 6;
        	this.button4.Text = "Новая игра";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Click += new System.EventHandler(this.button4_Click);
        	// 
        	// checkBox1
        	// 
        	this.checkBox1.AutoSize = true;
        	this.checkBox1.Location = new System.Drawing.Point(176, 39);
        	this.checkBox1.Name = "checkBox1";
        	this.checkBox1.Size = new System.Drawing.Size(112, 17);
        	this.checkBox1.TabIndex = 7;
        	this.checkBox1.Text = "Отсечение веток";
        	this.checkBox1.UseVisualStyleBackColor = true;
        	this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(307, 379);
        	this.Controls.Add(this.checkBox1);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.listBox1);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.pictureBox1);
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Крестики - нолики";
        	this.Load += new System.EventHandler(this.Form1_Load);
        	this.Click += new System.EventHandler(this.Form1_Click);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

