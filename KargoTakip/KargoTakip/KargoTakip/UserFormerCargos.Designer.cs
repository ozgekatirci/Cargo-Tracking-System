
namespace KargoTakip
{
    partial class UserFormerCargos
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFormerCargos = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kargo Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewFormerCargos
            // 
            this.listViewFormerCargos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.listViewFormerCargos.GridLines = true;
            this.listViewFormerCargos.HideSelection = false;
            this.listViewFormerCargos.Location = new System.Drawing.Point(-2, 61);
            this.listViewFormerCargos.Name = "listViewFormerCargos";
            this.listViewFormerCargos.Size = new System.Drawing.Size(912, 392);
            this.listViewFormerCargos.TabIndex = 2;
            this.listViewFormerCargos.UseCompatibleStateImageBehavior = false;
            this.listViewFormerCargos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Takip No";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gönderilen İl";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Teslim Alınan İl";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gönderilen Tarih";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Teslim Alınan Tarih";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alıcı";
            this.columnHeader1.Width = 46;
            // 
            // UserFormerCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.listViewFormerCargos);
            this.Controls.Add(this.label1);
            this.Name = "UserFormerCargos";
            this.Text = "UserFormerCargos";
            this.Load += new System.EventHandler(this.UserFormerCargos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFormerCargos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}