
namespace KargoTakip
{
    partial class UserHomes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomes));
            this.labelBackToStart = new System.Windows.Forms.Label();
            this.labelAccountChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBackToStart
            // 
            this.labelBackToStart.AutoSize = true;
            this.labelBackToStart.BackColor = System.Drawing.Color.Transparent;
            this.labelBackToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBackToStart.ForeColor = System.Drawing.Color.Khaki;
            this.labelBackToStart.Location = new System.Drawing.Point(729, 610);
            this.labelBackToStart.Name = "labelBackToStart";
            this.labelBackToStart.Size = new System.Drawing.Size(124, 29);
            this.labelBackToStart.TabIndex = 1;
            this.labelBackToStart.Text = "Çıkış Yap";
            this.labelBackToStart.Click += new System.EventHandler(this.labelBackToStart_Click);
            // 
            // labelAccountChange
            // 
            this.labelAccountChange.AutoSize = true;
            this.labelAccountChange.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAccountChange.ForeColor = System.Drawing.Color.Khaki;
            this.labelAccountChange.Location = new System.Drawing.Point(534, 564);
            this.labelAccountChange.Name = "labelAccountChange";
            this.labelAccountChange.Size = new System.Drawing.Size(532, 29);
            this.labelAccountChange.TabIndex = 2;
            this.labelAccountChange.Text = "Farklı bir hesapla giriş yapmak için tıklayınız.";
            this.labelAccountChange.Click += new System.EventHandler(this.labelAccountChange_Click);
            // 
            // UC_UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelBackToStart);
            this.Controls.Add(this.labelAccountChange);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1497, 672);
            this.MinimumSize = new System.Drawing.Size(1497, 672);
            this.Name = "UC_UserHome";
            this.Size = new System.Drawing.Size(1497, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackToStart;
        private System.Windows.Forms.Label labelAccountChange;
    }
}
