namespace TicTacToe
{
    partial class Main
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Turnlabel = new System.Windows.Forms.Label();
            this.PlayerTurnlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Turnlabel
            // 
            this.Turnlabel.AutoSize = true;
            this.Turnlabel.Location = new System.Drawing.Point(52, 45);
            this.Turnlabel.Name = "Turnlabel";
            this.Turnlabel.Size = new System.Drawing.Size(43, 13);
            this.Turnlabel.TabIndex = 10;
            this.Turnlabel.Text = "Ходит: ";
            // 
            // PlayerTurnlabel
            // 
            this.PlayerTurnlabel.AutoSize = true;
            this.PlayerTurnlabel.Location = new System.Drawing.Point(102, 45);
            this.PlayerTurnlabel.Name = "PlayerTurnlabel";
            this.PlayerTurnlabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerTurnlabel.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.PlayerTurnlabel);
            this.Controls.Add(this.Turnlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Крестики-нолики";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Turnlabel;
        private System.Windows.Forms.Label PlayerTurnlabel;
    }
}

