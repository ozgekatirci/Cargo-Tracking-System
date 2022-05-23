using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KargoTakip
{

    public partial class UserEnter : Form
    {
        public UserEnter()
        {
            InitializeComponent();

            AdminOrUserTab.DrawItem += new DrawItemEventHandler(AdminOrUserTab_DrawItem);
        }
       
        public static bool EmailKontrol(string inputEmail)
        {
            //control e-mail format
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }
        public static string selectedUsername;
        private void UserEnter_Load(object sender, EventArgs e)
        {           
            AdminOrUserTab.SelectedTab = tabPage_User;
            txtbox_userpassword.PasswordChar = '*';
            txtbox_signupPassword.PasswordChar = '*';
            txtbox_signupPasswordConfirm.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //control user enter datas properly
            if (txtbox_username.Text == "" || txtbox_userpassword.Text == "") 
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return; 
            }
            //find entered user info from user list
            if (Program.usersInfo.Any(User => User.Username == txtbox_username.Text
            && User.Password ==txtbox_userpassword.Text))
            {
                selectedUsername = txtbox_username.Text;
                UserOptions a = new UserOptions();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlış.");
            }
            txtbox_userpassword.Text = "";
            txtbox_username.Text = "";
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            //control user entered datas properly
            if (txtbox_signupEmail.Text == "" ||
                txtbox_signupNameSurname.Text == "" ||
                txtbox_signupID.Text == "" ||
                txtbox_signupPassword.Text == "" ||
                txtbox_signupPasswordConfirm.Text == "" ||
                txtbox_signupUsername.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }

            if (!EmailKontrol(txtbox_signupEmail.Text))
            {
                MessageBox.Show("Geçersiz e-mail formatı.");
                return;
            }

            if (txtbox_signupPassword.Text != txtbox_signupPasswordConfirm.Text)
            {
                MessageBox.Show("Şifreler eşleşmedi.");
                return;
            }

            foreach (var item in Program.usersInfo)
            {
                if (item.Username == txtbox_signupUsername.Text || item.Email == txtbox_signupEmail.Text)  
                {
                    MessageBox.Show("Kullanıcı zaten ekli.");
                    return;
                }
            }
            
            //add new user and add this user to list and save xml
            User u = new User
            {
                NameSurname = txtbox_signupNameSurname.Text,
                Username = txtbox_signupUsername.Text,
                Password =txtbox_signupPassword.Text,
                Id = Int32.Parse(txtbox_signupID.Text),
                Email = txtbox_signupEmail.Text
            };

            Program.usersInfo.Add(u);
            xmlUserFile.saveXMLFile(u);          
            MessageBox.Show("Kullanıcı eklendi.");
            txtbox_signupEmail.Text = "";
            txtbox_signupNameSurname.Text = "";
            txtbox_signupID.Text = "";
            txtbox_signupPassword.Text = "";
            txtbox_signupPasswordConfirm.Text = "";
            txtbox_signupUsername.Text = "";
        }   
        
        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            //for password visibility
            if (checkBox_showPassword.Checked) { txtbox_userpassword.PasswordChar = '\0'; }
            else { txtbox_userpassword.PasswordChar = '*'; }
        }          

        private void lbl_gotoSignUp_Click(object sender, EventArgs e)
        {
            AdminOrUserTab.SelectedTab = tabPage_SignUp;
            txtbox_userpassword.Text = "";
            txtbox_username.Text = "";
        }

        private void AdminOrUserTab_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtbox_userpassword.Text = "";
            txtbox_username.Text = "";
            txtbox_signupEmail.Text = "";
            txtbox_signupNameSurname.Text = "";
            txtbox_signupID.Text = "";
            txtbox_signupPassword.Text = "";
            txtbox_signupPasswordConfirm.Text = "";
            txtbox_signupUsername.Text = "";
        }

        private void txtbox_signupID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //id must be integer value.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);            
        }

        private void checkBoxPsw_CheckedChanged(object sender, EventArgs e)
        {
            //for password visibility
            if (checkBoxPsw.Checked) 
            { 
                txtbox_signupPassword.PasswordChar = '\0';
                txtbox_signupPasswordConfirm.PasswordChar = '\0';
            }
            else 
            {
                txtbox_signupPassword.PasswordChar = '*';
                txtbox_signupPasswordConfirm.PasswordChar = '*';
            }
        }
        
        private void AdminOrUserTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = AdminOrUserTab.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = AdminOrUserTab.GetTabRect(e.Index);
            Color a = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]);
            Color b = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[1]);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
              
                _textBrush = new SolidBrush(ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]));
                SolidBrush brush = new SolidBrush(b);
                g.FillRectangle(brush, e.Bounds);
            }
            else
            {
                SolidBrush brush = new SolidBrush(a);
                g.FillRectangle(brush, e.Bounds);
                _textBrush = new System.Drawing.SolidBrush(b);
                //e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
