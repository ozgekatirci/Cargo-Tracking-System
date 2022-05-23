
namespace KargoTakip
{
    partial class UserSupport
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
            this.labelSupport = new System.Windows.Forms.Label();
            this.textBoxSupport = new System.Windows.Forms.TextBox();
            this.buttonSupport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Location = new System.Drawing.Point(124, 156);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(164, 17);
            this.labelSupport.TabIndex = 0;
            this.labelSupport.Text = "Şikayet veya Önerileriniz";
            // 
            // textBoxSupport
            // 
            this.textBoxSupport.Location = new System.Drawing.Point(355, 139);
            this.textBoxSupport.Multiline = true;
            this.textBoxSupport.Name = "textBoxSupport";
            this.textBoxSupport.Size = new System.Drawing.Size(336, 191);
            this.textBoxSupport.TabIndex = 1;
            // 
            // buttonSupport
            // 
            this.buttonSupport.Location = new System.Drawing.Point(588, 368);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(75, 23);
            this.buttonSupport.TabIndex = 2;
            this.buttonSupport.Text = "Gönder";
            this.buttonSupport.UseVisualStyleBackColor = true;
            this.buttonSupport.Click += new System.EventHandler(this.buttonSupport_Click);
            // 
            // UserSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.textBoxSupport);
            this.Controls.Add(this.labelSupport);
            this.Name = "UserSupport";
            this.Text = "UserSupport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.TextBox textBoxSupport;
        private System.Windows.Forms.Button buttonSupport;
    }
}