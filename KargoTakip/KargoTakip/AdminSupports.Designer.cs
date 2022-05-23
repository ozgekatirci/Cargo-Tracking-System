
namespace KargoTakip
{
    partial class AdminSupports
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
            this.buttonStateChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSupport = new System.Windows.Forms.ListView();
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonStateChange
            // 
            this.buttonStateChange.BackColor = System.Drawing.Color.Khaki;
            this.buttonStateChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStateChange.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonStateChange.Location = new System.Drawing.Point(867, 133);
            this.buttonStateChange.Name = "buttonStateChange";
            this.buttonStateChange.Size = new System.Drawing.Size(373, 38);
            this.buttonStateChange.TabIndex = 9;
            this.buttonStateChange.Text = "Değerlendirildi Olarak İşaretle";
            this.buttonStateChange.UseVisualStyleBackColor = false;
            this.buttonStateChange.Click += new System.EventHandler(this.buttonStateChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(360, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şikayet ve Öneriler";
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
            this.listViewSupport.Location = new System.Drawing.Point(357, 191);
            this.listViewSupport.Name = "listViewSupport";
            this.listViewSupport.Size = new System.Drawing.Size(893, 362);
            this.listViewSupport.TabIndex = 7;
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
            // UC_AdminSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStateChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSupport);
            this.MaximumSize = new System.Drawing.Size(1560, 672);
            this.MinimumSize = new System.Drawing.Size(1560, 672);
            this.Name = "UC_AdminSupport";
            this.Size = new System.Drawing.Size(1560, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStateChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSupport;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ColumnHeader columnState;
    }
}
