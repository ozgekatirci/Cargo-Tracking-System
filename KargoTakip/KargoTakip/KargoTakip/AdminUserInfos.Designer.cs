
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserInfos));
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelUserInfos = new System.Windows.Forms.Label();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listViewUser.Location = new System.Drawing.Point(298, 189);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(909, 486);
            this.listViewUser.TabIndex = 0;
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
            // labelUserInfos
            // 
            this.labelUserInfos.AutoSize = true;
            this.labelUserInfos.BackColor = System.Drawing.Color.Transparent;
            this.labelUserInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUserInfos.ForeColor = System.Drawing.Color.Khaki;
            this.labelUserInfos.Location = new System.Drawing.Point(274, 133);
            this.labelUserInfos.Name = "labelUserInfos";
            this.labelUserInfos.Size = new System.Drawing.Size(170, 25);
            this.labelUserInfos.TabIndex = 1;
            this.labelUserInfos.Text = "Kullanıcı Bilgileri";
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.BackColor = System.Drawing.Color.Khaki;
            this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUserDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUserDelete.Location = new System.Drawing.Point(953, 125);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(209, 33);
            this.buttonUserDelete.TabIndex = 2;
            this.buttonUserDelete.Text = "Kullanıcıyı Sil";
            this.buttonUserDelete.UseVisualStyleBackColor = false;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // AdminUserInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 635);
            this.Controls.Add(this.buttonUserDelete);
            this.Controls.Add(this.labelUserInfos);
            this.Controls.Add(this.listViewUser);
            this.Name = "AdminUserInfos";
            this.Text = "AdminUserInfos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label labelUserInfos;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.Button buttonUserDelete;
    }
}