namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.FirstPlayerNamelabel = new System.Windows.Forms.Label();
            this.SecondPlayerNamelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.Errorlabel1 = new System.Windows.Forms.Label();
            this.Errorlabel2 = new System.Windows.Forms.Label();
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
            // button
            // 
            this.button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(150, 270);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 40);
            this.button.TabIndex = 4;
            this.button.Text = "Начать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Errorlabel1
            // 
            this.Errorlabel1.AutoSize = true;
            this.Errorlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Errorlabel1.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel1.Location = new System.Drawing.Point(137, 92);
            this.Errorlabel1.Name = "Errorlabel1";
            this.Errorlabel1.Size = new System.Drawing.Size(81, 16);
            this.Errorlabel1.TabIndex = 5;
            this.Errorlabel1.Text = "ErrorLabel";
            // 
            // Errorlabel2
            // 
            this.Errorlabel2.AutoSize = true;
            this.Errorlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Errorlabel2.ForeColor = System.Drawing.Color.Red;
            this.Errorlabel2.Location = new System.Drawing.Point(137, 161);
            this.Errorlabel2.Name = "Errorlabel2";
            this.Errorlabel2.Size = new System.Drawing.Size(81, 16);
            this.Errorlabel2.TabIndex = 6;
            this.Errorlabel2.Text = "ErrorLabel";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.Errorlabel2);
            this.Controls.Add(this.Errorlabel1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecondPlayerNamelabel);
            this.Controls.Add(this.FirstPlayerNamelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label Errorlabel1;
        private System.Windows.Forms.Label Errorlabel2;
    }
}