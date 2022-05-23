
namespace KargoTakip
{
    partial class AdminEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEnter));
            this.checkbox_adminPassword = new System.Windows.Forms.CheckBox();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_adminPassword = new System.Windows.Forms.TextBox();
            this.txtbox_adminUserName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkbox_adminPassword
            // 
            this.checkbox_adminPassword.AutoSize = true;
            this.checkbox_adminPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_adminPassword.ForeColor = System.Drawing.Color.Khaki;
            this.checkbox_adminPassword.Location = new System.Drawing.Point(522, 204);
            this.checkbox_adminPassword.Name = "checkbox_adminPassword";
            this.checkbox_adminPassword.Size = new System.Drawing.Size(129, 21);
            this.checkbox_adminPassword.TabIndex = 27;
            this.checkbox_adminPassword.Text = "Show Password";
            this.checkbox_adminPassword.UseVisualStyleBackColor = false;
            this.checkbox_adminPassword.CheckedChanged += new System.EventHandler(this.checkbox_adminPassword_CheckedChanged);
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.BackColor = System.Drawing.Color.Khaki;
            this.btn_adminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adminLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_adminLogin.Location = new System.Drawing.Point(465, 283);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(98, 31);
            this.btn_adminLogin.TabIndex = 26;
            this.btn_adminLogin.Text = "Login";
            this.btn_adminLogin.UseVisualStyleBackColor = false;
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(168, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Khaki;
            this.label9.Location = new System.Drawing.Point(168, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "User Name";
            // 
            // txtbox_adminPassword
            // 
            this.txtbox_adminPassword.Location = new System.Drawing.Point(268, 205);
            this.txtbox_adminPassword.Name = "txtbox_adminPassword";
            this.txtbox_adminPassword.Size = new System.Drawing.Size(229, 22);
            this.txtbox_adminPassword.TabIndex = 23;
            // 
            // txtbox_adminUserName
            // 
            this.txtbox_adminUserName.Location = new System.Drawing.Point(268, 167);
            this.txtbox_adminUserName.Name = "txtbox_adminUserName";
            this.txtbox_adminUserName.Size = new System.Drawing.Size(229, 22);
            this.txtbox_adminUserName.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(704, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 57);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkbox_adminPassword);
            this.Controls.Add(this.btn_adminLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_adminPassword);
            this.Controls.Add(this.txtbox_adminUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEnter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_adminPassword;
        private System.Windows.Forms.Button btn_adminLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_adminPassword;
        private System.Windows.Forms.TextBox txtbox_adminUserName;
        private System.Windows.Forms.Button button2;
    }
}