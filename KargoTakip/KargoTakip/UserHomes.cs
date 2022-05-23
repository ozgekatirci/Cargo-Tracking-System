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
    public partial class UserHomes : UserControl
    {
        public UserHomes()
        {
            InitializeComponent();
        }

        private void labelBackToStart_Click(object sender, EventArgs e)
        {
            StartScreen a = new StartScreen();
            UserOptions anaform = (UserOptions)Application.OpenForms["UserOptions"]; 
            anaform.Close();
            a.Show();
        }
        private void labelAccountChange_Click(object sender, EventArgs e)
        {
            UserEnter a = new UserEnter();
            UserOptions anaform2 = (UserOptions)Application.OpenForms["UserOptions"];
            anaform2.Close();
            a.Show();
        }
    }
}
