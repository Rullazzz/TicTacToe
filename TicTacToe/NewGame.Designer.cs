﻿namespace TicTacToe
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstPlayerNamelabel = new System.Windows.Forms.Label();
            this.SecondPlayerNamelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstPlayerNamelabel
            // 
            this.FirstPlayerNamelabel.AutoSize = true;
            this.FirstPlayerNamelabel.Location = new System.Drawing.Point(41, 72);
            this.FirstPlayerNamelabel.Name = "FirstPlayerNamelabel";
            this.FirstPlayerNamelabel.Size = new System.Drawing.Size(76, 13);
            this.FirstPlayerNamelabel.TabIndex = 0;
            this.FirstPlayerNamelabel.Text = "Имя игрока 1";
            // 
            // SecondPlayerNamelabel
            // 
            this.SecondPlayerNamelabel.AutoSize = true;
            this.SecondPlayerNamelabel.Location = new System.Drawing.Point(41, 141);
            this.SecondPlayerNamelabel.Name = "SecondPlayerNamelabel";
            this.SecondPlayerNamelabel.Size = new System.Drawing.Size(76, 13);
            this.SecondPlayerNamelabel.TabIndex = 1;
            this.SecondPlayerNamelabel.Text = "Имя игрока 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Gamer_1\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Gamer_2\r\n";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecondPlayerNamelabel);
            this.Controls.Add(this.FirstPlayerNamelabel);
            this.MaximizeBox = false;
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstPlayerNamelabel;
        private System.Windows.Forms.Label SecondPlayerNamelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}