
namespace KargoTakip
{
    partial class AdminSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSupport));
            this.listViewSupport = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStateChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSupport
            // 
            this.listViewSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSupport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUserName,
            this.columnText,
            this.columnState});
            this.listViewSupport.GridLines = true;
            this.listViewSupport.HideSelection = false;
            this.listViewSupport.Location = new System.Drawing.Point(255, 163);
            this.listViewSupport.Name = "listViewSupport";
            this.listViewSupport.Size = new System.Drawing.Size(1144, 520);
            this.listViewSupport.TabIndex = 0;
            this.listViewSupport.UseCompatibleStateImageBehavior = false;
            this.listViewSupport.View = System.Windows.Forms.View.Details;
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "Kullanıcı Adı";
            this.columnUserName.Width = 150;
            // 
            // columnText
            // 
            this.columnText.Text = "Şikayet / Öneri";
            this.columnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnText.Width = 534;
            // 
            // columnState
            // 
            this.columnState.Text = "Şikayet Durumu";
            this.columnState.Width = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(293, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şikayet ve Öneriler";
            // 
            // buttonStateChange
            // 
            this.buttonStateChange.BackColor = System.Drawing.Color.Khaki;
            this.buttonStateChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStateChange.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonStateChange.Location = new System.Drawing.Point(949, 97);
            this.buttonStateChange.Name = "buttonStateChange";
            this.buttonStateChange.Size = new System.Drawing.Size(373, 38);
            this.buttonStateChange.TabIndex = 6;
            this.buttonStateChange.Text = "Değerlendirildi Olarak İşaretle";
            this.buttonStateChange.UseVisualStyleBackColor = false;
            this.buttonStateChange.Click += new System.EventHandler(this.buttonStateChange_Click);
            // 
            // AdminSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1225, 684);
            this.Controls.Add(this.buttonStateChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSupport);
            this.Name = "AdminSupport";
            this.Text = "AdminSupport";
            this.Load += new System.EventHandler(this.AdminSupport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.Button buttonStateChange;
        private System.Windows.Forms.ColumnHeader columnState;
    }
}