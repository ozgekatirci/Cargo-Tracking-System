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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            //for buttons' back color
            ButtonUserEnter.BackColor = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]); 
            ButtonAdminEnter.BackColor= ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]);
        }

        private void ButtonUserEnter_Click(object sender, EventArgs e)
        {
            //open UserEnter form if ButtonUserEnter is clicked
            UserEnter a = new UserEnter();
            this.Hide();
            a.Show();
        }

        private void ButtonAdminEnter_Click(object sender, EventArgs e)
        {
            //open AdminEnter form if ButtonAdminEnter is clicked
            AdminEnter a = new AdminEnter();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit from program if button1 is cliked
            Application.Exit();
        }
    }
}
