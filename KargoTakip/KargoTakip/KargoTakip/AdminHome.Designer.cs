
namespace KargoTakip
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.labelBackToStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBackToStart
            // 
            this.labelBackToStart.AutoSize = true;
            this.labelBackToStart.BackColor = System.Drawing.Color.Transparent;
            this.labelBackToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBackToStart.ForeColor = System.Drawing.Color.White;
            this.labelBackToStart.Location = new System.Drawing.Point(685, 598);
            this.labelBackToStart.Name = "labelBackToStart";
            this.labelBackToStart.Size = new System.Drawing.Size(144, 32);
            this.labelBackToStart.TabIndex = 1;
            this.labelBackToStart.Text = "Çıkış Yap";
            this.labelBackToStart.Click += new System.EventHandler(this.labelBackToStart_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 1016);
            this.Controls.Add(this.labelBackToStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackToStart;
    }
}