
namespace KargoTakip
{
    partial class UserHome
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
            this.labelAccountChange = new System.Windows.Forms.Label();
            this.labelBackToStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAccountChange
            // 
            this.labelAccountChange.AutoSize = true;
            this.labelAccountChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAccountChange.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelAccountChange.Location = new System.Drawing.Point(124, 176);
            this.labelAccountChange.Name = "labelAccountChange";
            this.labelAccountChange.Size = new System.Drawing.Size(438, 25);
            this.labelAccountChange.TabIndex = 0;
            this.labelAccountChange.Text = "Farklı bir hesapla giriş yapmak için tıklayınız.";
            this.labelAccountChange.Click += new System.EventHandler(this.labelAccountChange_Click);
            // 
            // labelBackToStart
            // 
            this.labelBackToStart.AutoSize = true;
            this.labelBackToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBackToStart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBackToStart.Location = new System.Drawing.Point(124, 236);
            this.labelBackToStart.Name = "labelBackToStart";
            this.labelBackToStart.Size = new System.Drawing.Size(104, 25);
            this.labelBackToStart.TabIndex = 0;
            this.labelBackToStart.Text = "Çıkış Yap";
            this.labelBackToStart.Click += new System.EventHandler(this.labelBackToStart_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBackToStart);
            this.Controls.Add(this.labelAccountChange);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccountChange;
        private System.Windows.Forms.Label labelBackToStart;
    }
}