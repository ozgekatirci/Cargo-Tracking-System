
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSupport = new System.Windows.Forms.Button();
            this.textBoxSupport = new System.Windows.Forms.TextBox();
            this.labelSupport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSupport
            // 
            this.buttonSupport.BackColor = System.Drawing.Color.Khaki;
            this.buttonSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSupport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSupport.Location = new System.Drawing.Point(1064, 421);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(134, 56);
            this.buttonSupport.TabIndex = 5;
            this.buttonSupport.Text = "Gönder";
            this.buttonSupport.UseVisualStyleBackColor = false;
            this.buttonSupport.Click += new System.EventHandler(this.buttonSupport_Click);
            // 
            // textBoxSupport
            // 
            this.textBoxSupport.Location = new System.Drawing.Point(587, 204);
            this.textBoxSupport.Multiline = true;
            this.textBoxSupport.Name = "textBoxSupport";
            this.textBoxSupport.Size = new System.Drawing.Size(611, 211);
            this.textBoxSupport.TabIndex = 4;
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.BackColor = System.Drawing.Color.Transparent;
            this.labelSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSupport.ForeColor = System.Drawing.Color.Khaki;
            this.labelSupport.Location = new System.Drawing.Point(216, 204);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(354, 32);
            this.labelSupport.TabIndex = 3;
            this.labelSupport.Text = "Şikayet veya Önerileriniz";
            // 
            // UC_UserSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.textBoxSupport);
            this.Controls.Add(this.labelSupport);
            this.MaximumSize = new System.Drawing.Size(1497, 672);
            this.MinimumSize = new System.Drawing.Size(1497, 672);
            this.Name = "UC_UserSupport";
            this.Size = new System.Drawing.Size(1497, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSupport;
        private System.Windows.Forms.TextBox textBoxSupport;
        private System.Windows.Forms.Label labelSupport;
    }
}
