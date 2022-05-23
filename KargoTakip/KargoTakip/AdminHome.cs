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
    public partial class AdminHome : UserControl
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void labelBackToStart_Click(object sender, EventArgs e)
        {
            StartScreen a = new StartScreen();
            AdminOptions anaform = (AdminOptions)Application.OpenForms["AdminOptions"]; 
            anaform.Close();
            a.Show();
        }
    }
}
