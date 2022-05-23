
namespace KargoTakip
{
    partial class AdminStaffInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStaffInfos));
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewStaff = new System.Windows.Forms.ListView();
            this.columnNameSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.Khaki;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonModify.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonModify.Location = new System.Drawing.Point(640, 168);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(125, 32);
            this.buttonModify.TabIndex = 25;
            this.buttonModify.Text = "Güncelle";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Khaki;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDelete.Location = new System.Drawing.Point(640, 129);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 32);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Khaki;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAdd.Location = new System.Drawing.Point(640, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 32);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(137, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "İş Başlama Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(170, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Görevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(180, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "TC ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(137, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "İsim Soyisim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxJob.Location = new System.Drawing.Point(350, 146);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(205, 30);
            this.textBoxJob.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxId.Location = new System.Drawing.Point(350, 118);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(205, 30);
            this.textBoxId.TabIndex = 17;
            // 
            // textBoxNameSurname
            // 
            this.textBoxNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNameSurname.Location = new System.Drawing.Point(350, 90);
            this.textBoxNameSurname.Name = "textBoxNameSurname";
            this.textBoxNameSurname.Size = new System.Drawing.Size(205, 30);
            this.textBoxNameSurname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(120, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Personel Listesi";
            // 
            // listViewStaff
            // 
            this.listViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameSurname,
            this.columnId,
            this.columnJob,
            this.columnStartDate});
            this.listViewStaff.GridLines = true;
            this.listViewStaff.HideSelection = false;
            this.listViewStaff.Location = new System.Drawing.Point(105, 324);
            this.listViewStaff.Name = "listViewStaff";
            this.listViewStaff.Size = new System.Drawing.Size(1048, 270);
            this.listViewStaff.TabIndex = 13;
            this.listViewStaff.UseCompatibleStateImageBehavior = false;
            this.listViewStaff.View = System.Windows.Forms.View.Details;
            // 
            // columnNameSurname
            // 
            this.columnNameSurname.Text = "İsim Soyisim";
            this.columnNameSurname.Width = 150;
            // 
            // columnId
            // 
            this.columnId.Text = "TC";
            this.columnId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnId.Width = 150;
            // 
            // columnJob
            // 
            this.columnJob.Text = "Görevi";
            this.columnJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnJob.Width = 227;
            // 
            // columnStartDate
            // 
            this.columnStartDate.Text = "İşe Başlama Tarihi";
            this.columnStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnStartDate.Width = 270;
            // 
            // UC_AdminStaffInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNameSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStaff);
            this.MaximumSize = new System.Drawing.Size(1560, 672);
            this.MinimumSize = new System.Drawing.Size(1560, 672);
            this.Name = "UC_AdminStaffInfos";
            this.Size = new System.Drawing.Size(1560, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStaff;
        private System.Windows.Forms.ColumnHeader columnNameSurname;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnJob;
        private System.Windows.Forms.ColumnHeader columnStartDate;
    }
}
