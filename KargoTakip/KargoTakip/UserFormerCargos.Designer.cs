
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFormerCargos));
            this.listViewFormerCargos = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.listViewFormerCargos.Location = new System.Drawing.Point(266, 227);
            this.listViewFormerCargos.Name = "listViewFormerCargos";
            this.listViewFormerCargos.Size = new System.Drawing.Size(851, 392);
            this.listViewFormerCargos.TabIndex = 4;
            this.listViewFormerCargos.UseCompatibleStateImageBehavior = false;
            this.listViewFormerCargos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Takip No";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gönderilen İl";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Teslim Alınan İl";
            this.columnHeader6.Width = 144;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gönderilen Tarih";
            this.columnHeader8.Width = 166;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Teslim Alınan Tarih";
            this.columnHeader9.Width = 204;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alıcı";
            this.columnHeader1.Width = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(260, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kargo Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_UserFormerCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.listViewFormerCargos);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1497, 672);
            this.MinimumSize = new System.Drawing.Size(1497, 672);
            this.Name = "UC_UserFormerCargos";
            this.Size = new System.Drawing.Size(1497, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFormerCargos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
    }
}
