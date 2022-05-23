using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class AdminEnter : Form
    {
        public AdminEnter()
        {
            InitializeComponent();
            txtbox_adminPassword.PasswordChar = '*';
        }
        private void checkbox_adminPassword_CheckedChanged(object sender, EventArgs e)
        {           
                if (checkbox_adminPassword.Checked) { txtbox_adminPassword.PasswordChar = '\0'; }
                else { txtbox_adminPassword.PasswordChar = '*'; }         
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            if (txtbox_adminUserName.Text == "" || txtbox_adminPassword.Text=="")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }
            if ("admin" == txtbox_adminUserName.Text && "admin" == txtbox_adminPassword.Text)
            {
                AdminOptions a = new AdminOptions();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Admin bilgileri yanlış.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
