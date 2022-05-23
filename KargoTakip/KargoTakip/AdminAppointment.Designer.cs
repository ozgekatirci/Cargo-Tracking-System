
namespace KargoTakip
{
    partial class AdminAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAppointment));
            this.buttonAppDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAppointment = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTrackNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAppDelete
            // 
            this.buttonAppDelete.BackColor = System.Drawing.Color.Khaki;
            this.buttonAppDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAppDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAppDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAppDelete.Location = new System.Drawing.Point(1020, 213);
            this.buttonAppDelete.Name = "buttonAppDelete";
            this.buttonAppDelete.Size = new System.Drawing.Size(131, 42);
            this.buttonAppDelete.TabIndex = 7;
            this.buttonAppDelete.Text = "SİL";
            this.buttonAppDelete.UseVisualStyleBackColor = false;
            this.buttonAppDelete.Click += new System.EventHandler(this.buttonAppDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(304, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Randevular";
            // 
            // listViewAppointment
            // 
            this.listViewAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnTrackNo,
            this.columnDate});
            this.listViewAppointment.GridLines = true;
            this.listViewAppointment.HideSelection = false;
            this.listViewAppointment.Location = new System.Drawing.Point(309, 267);
            this.listViewAppointment.Name = "listViewAppointment";
            this.listViewAppointment.Size = new System.Drawing.Size(842, 318);
            this.listViewAppointment.TabIndex = 5;
            this.listViewAppointment.UseCompatibleStateImageBehavior = false;
            this.listViewAppointment.View = System.Windows.Forms.View.Details;
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "Kullanıcı Adı";
            this.columnUserName.Width = 194;
            // 
            // columnTrackNo
            // 
            this.columnTrackNo.Text = "Kargo Takip No";
            this.columnTrackNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTrackNo.Width = 213;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Randevu Zamanı";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 243;
            // 
            // UC_AdminAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonAppDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAppointment);
            this.MaximumSize = new System.Drawing.Size(1560, 672);
            this.MinimumSize = new System.Drawing.Size(1560, 672);
            this.Name = "UC_AdminAppointment";
            this.Size = new System.Drawing.Size(1560, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAppDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAppointment;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnTrackNo;
        private System.Windows.Forms.ColumnHeader columnDate;
    }
}
