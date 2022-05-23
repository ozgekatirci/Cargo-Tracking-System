
namespace KargoTakip
{
    partial class UserOptions
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
            this.buttonCargoTracking = new System.Windows.Forms.Button();
            this.buttonCargoSend = new System.Windows.Forms.Button();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonFormerCargo = new System.Windows.Forms.Button();
            this.buttonSupport = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAppointmentCancel = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCargoTracking
            // 
            this.buttonCargoTracking.Location = new System.Drawing.Point(345, 45);
            this.buttonCargoTracking.Name = "buttonCargoTracking";
            this.buttonCargoTracking.Size = new System.Drawing.Size(103, 60);
            this.buttonCargoTracking.TabIndex = 2;
            this.buttonCargoTracking.Text = "Kargo Takip";
            this.buttonCargoTracking.UseVisualStyleBackColor = true;
            this.buttonCargoTracking.Click += new System.EventHandler(this.buttonCargoTracking_Click);
            // 
            // buttonCargoSend
            // 
            this.buttonCargoSend.Location = new System.Drawing.Point(481, 45);
            this.buttonCargoSend.Name = "buttonCargoSend";
            this.buttonCargoSend.Size = new System.Drawing.Size(103, 60);
            this.buttonCargoSend.TabIndex = 2;
            this.buttonCargoSend.Text = "Kurye Çağır";
            this.buttonCargoSend.UseVisualStyleBackColor = true;
            this.buttonCargoSend.Click += new System.EventHandler(this.buttonCargoSend_Click);
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.Location = new System.Drawing.Point(617, 45);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(103, 60);
            this.buttonAppointment.TabIndex = 2;
            this.buttonAppointment.Text = "Randevu Oluştur";
            this.buttonAppointment.UseVisualStyleBackColor = true;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonFormerCargo
            // 
            this.buttonFormerCargo.Location = new System.Drawing.Point(753, 45);
            this.buttonFormerCargo.Name = "buttonFormerCargo";
            this.buttonFormerCargo.Size = new System.Drawing.Size(103, 60);
            this.buttonFormerCargo.TabIndex = 2;
            this.buttonFormerCargo.Text = "Önceki Kargolarım";
            this.buttonFormerCargo.UseVisualStyleBackColor = true;
            this.buttonFormerCargo.Click += new System.EventHandler(this.buttonFormerCargo_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.Location = new System.Drawing.Point(889, 45);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(103, 60);
            this.buttonSupport.TabIndex = 2;
            this.buttonSupport.Text = "Şikayet ve Öneriler";
            this.buttonSupport.UseVisualStyleBackColor = true;
            this.buttonSupport.Click += new System.EventHandler(this.buttonSupport_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Location = new System.Drawing.Point(12, 167);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1910, 527);
            this.panelDesktopPanel.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonAppointmentCancel);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.buttonCargoTracking);
            this.panelMenu.Controls.Add(this.buttonCargoSend);
            this.panelMenu.Controls.Add(this.buttonSupport);
            this.panelMenu.Controls.Add(this.buttonAppointment);
            this.panelMenu.Controls.Add(this.buttonFormerCargo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1924, 138);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonAppointmentCancel
            // 
            this.buttonAppointmentCancel.Location = new System.Drawing.Point(1025, 45);
            this.buttonAppointmentCancel.Name = "buttonAppointmentCancel";
            this.buttonAppointmentCancel.Size = new System.Drawing.Size(103, 60);
            this.buttonAppointmentCancel.TabIndex = 4;
            this.buttonAppointmentCancel.Text = "Randevu Listesi";
            this.buttonAppointmentCancel.UseVisualStyleBackColor = true;
            this.buttonAppointmentCancel.Click += new System.EventHandler(this.buttonAppointmentCancel_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(1161, 45);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(103, 60);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Anasayfa";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // UserOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktopPanel);
            this.Name = "UserOptions";
            this.Text = "UserOptions";
            this.Load += new System.EventHandler(this.UserOptions_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCargoTracking;
        private System.Windows.Forms.Button buttonCargoSend;
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonFormerCargo;
        private System.Windows.Forms.Button buttonSupport;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAppointmentCancel;
    }
}