
namespace KargoTakip
{
    partial class UserAppointmentCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAppointmentCancel));
            this.buttonAppCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAppointment = new System.Windows.Forms.ListView();
            this.columnTrackNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAppCancel
            // 
            this.buttonAppCancel.BackColor = System.Drawing.Color.Khaki;
            this.buttonAppCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAppCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAppCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAppCancel.Location = new System.Drawing.Point(992, 228);
            this.buttonAppCancel.Name = "buttonAppCancel";
            this.buttonAppCancel.Size = new System.Drawing.Size(101, 33);
            this.buttonAppCancel.TabIndex = 9;
            this.buttonAppCancel.Text = "İptal Et";
            this.buttonAppCancel.UseVisualStyleBackColor = false;
            this.buttonAppCancel.Click += new System.EventHandler(this.buttonAppCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(221, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Randevular";
            // 
            // listViewAppointment
            // 
            this.listViewAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTrackNo,
            this.columnDate});
            this.listViewAppointment.GridLines = true;
            this.listViewAppointment.HideSelection = false;
            this.listViewAppointment.Location = new System.Drawing.Point(226, 267);
            this.listViewAppointment.Name = "listViewAppointment";
            this.listViewAppointment.Size = new System.Drawing.Size(907, 303);
            this.listViewAppointment.TabIndex = 7;
            this.listViewAppointment.UseCompatibleStateImageBehavior = false;
            this.listViewAppointment.View = System.Windows.Forms.View.Details;
            // 
            // columnTrackNo
            // 
            this.columnTrackNo.Text = "Kargo Takip No";
            this.columnTrackNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTrackNo.Width = 295;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Randevu Zamanı";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 569;
            // 
            // UC_UserAppointmentCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonAppCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAppointment);
            this.MaximumSize = new System.Drawing.Size(1497, 672);
            this.MinimumSize = new System.Drawing.Size(1497, 672);
            this.Name = "UC_UserAppointmentCancel";
            this.Size = new System.Drawing.Size(1497, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAppCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAppointment;
        private System.Windows.Forms.ColumnHeader columnTrackNo;
        private System.Windows.Forms.ColumnHeader columnDate;
    }
}
