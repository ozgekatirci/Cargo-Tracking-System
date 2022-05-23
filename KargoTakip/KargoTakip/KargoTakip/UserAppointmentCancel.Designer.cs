
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewAppointment = new System.Windows.Forms.ListView();
            this.columnTrackNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAppCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAppointment
            // 
            this.listViewAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTrackNo,
            this.columnDate});
            this.listViewAppointment.GridLines = true;
            this.listViewAppointment.HideSelection = false;
            this.listViewAppointment.Location = new System.Drawing.Point(0, 165);
            this.listViewAppointment.Name = "listViewAppointment";
            this.listViewAppointment.Size = new System.Drawing.Size(802, 283);
            this.listViewAppointment.TabIndex = 3;
            this.listViewAppointment.UseCompatibleStateImageBehavior = false;
            this.listViewAppointment.View = System.Windows.Forms.View.Details;
            // 
            // columnTrackNo
            // 
            this.columnTrackNo.Text = "Kargo Takip No";
            this.columnTrackNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTrackNo.Width = 150;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Randevu Zamanı";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 250;
            // 
            // buttonAppCancel
            // 
            this.buttonAppCancel.Location = new System.Drawing.Point(606, 92);
            this.buttonAppCancel.Name = "buttonAppCancel";
            this.buttonAppCancel.Size = new System.Drawing.Size(82, 29);
            this.buttonAppCancel.TabIndex = 6;
            this.buttonAppCancel.Text = "İptal Et";
            this.buttonAppCancel.UseVisualStyleBackColor = true;
            this.buttonAppCancel.Click += new System.EventHandler(this.buttonAppCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Randevular";
            // 
            // UserAppointmentCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAppCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAppointment);
            this.Name = "UserAppointmentCancel";
            this.Text = "UserCargoCancel";
            this.Load += new System.EventHandler(this.UserCargoCancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAppointment;
        private System.Windows.Forms.ColumnHeader columnTrackNo;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button buttonAppCancel;
        private System.Windows.Forms.Label label1;
    }
}