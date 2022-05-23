
namespace KargoTakip
{
    partial class AdminUserInfos
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
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.labelUserInfos = new System.Windows.Forms.Label();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.BackColor = System.Drawing.Color.Khaki;
            this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUserDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUserDelete.Location = new System.Drawing.Point(991, 166);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(181, 33);
            this.buttonUserDelete.TabIndex = 5;
            this.buttonUserDelete.Text = "Kullanıcıyı Sil";
            this.buttonUserDelete.UseVisualStyleBackColor = false;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // labelUserInfos
            // 
            this.labelUserInfos.AutoSize = true;
            this.labelUserInfos.BackColor = System.Drawing.Color.Transparent;
            this.labelUserInfos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.labelUserInfos.ForeColor = System.Drawing.Color.Khaki;
            this.labelUserInfos.Location = new System.Drawing.Point(376, 164);
            this.labelUserInfos.Name = "labelUserInfos";
            this.labelUserInfos.Size = new System.Drawing.Size(250, 32);
            this.labelUserInfos.TabIndex = 4;
            this.labelUserInfos.Text = "Kullanıcı Bilgileri";
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnUsername,
            this.columnEmail});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(381, 235);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(791, 369);
            this.listViewUser.TabIndex = 3;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "TC No";
            this.columnId.Width = 128;
            // 
            // columnName
            // 
            this.columnName.Text = "İsim Soyisim";
            this.columnName.Width = 150;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Kullanıcı Adı";
            this.columnUsername.Width = 184;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "E-mail";
            this.columnEmail.Width = 150;
            // 
            // UC_AdminUserInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.labelUserInfos);
            this.Controls.Add(this.listViewUser);
            this.MaximumSize = new System.Drawing.Size(1560, 672);
            this.MinimumSize = new System.Drawing.Size(1560, 672);
            this.Name = "UC_AdminUserInfos";
            this.Size = new System.Drawing.Size(1560, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Label labelUserInfos;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnEmail;
    }
}
