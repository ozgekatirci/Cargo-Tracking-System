
namespace KargoTakip
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.ButtonUserEnter = new System.Windows.Forms.Button();
            this.ButtonAdminEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUserEnter
            // 
            this.ButtonUserEnter.BackColor = System.Drawing.Color.Khaki;
            this.ButtonUserEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUserEnter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ButtonUserEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUserEnter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUserEnter.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonUserEnter.Location = new System.Drawing.Point(565, 539);
            this.ButtonUserEnter.Name = "ButtonUserEnter";
            this.ButtonUserEnter.Size = new System.Drawing.Size(184, 64);
            this.ButtonUserEnter.TabIndex = 0;
            this.ButtonUserEnter.Text = "User ";
            this.ButtonUserEnter.UseVisualStyleBackColor = false;
            this.ButtonUserEnter.Click += new System.EventHandler(this.ButtonUserEnter_Click);
            // 
            // ButtonAdminEnter
            // 
            this.ButtonAdminEnter.BackColor = System.Drawing.Color.Khaki;
            this.ButtonAdminEnter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ButtonAdminEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAdminEnter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdminEnter.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonAdminEnter.Location = new System.Drawing.Point(791, 539);
            this.ButtonAdminEnter.Name = "ButtonAdminEnter";
            this.ButtonAdminEnter.Size = new System.Drawing.Size(184, 64);
            this.ButtonAdminEnter.TabIndex = 0;
            this.ButtonAdminEnter.Text = "Admin";
            this.ButtonAdminEnter.UseVisualStyleBackColor = false;
            this.ButtonAdminEnter.Click += new System.EventHandler(this.ButtonAdminEnter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1437, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 676);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonAdminEnter);
            this.Controls.Add(this.ButtonUserEnter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 676);
            this.MinimumSize = new System.Drawing.Size(1500, 676);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUserEnter;
        private System.Windows.Forms.Button ButtonAdminEnter;
        private System.Windows.Forms.Button button1;
    }
}