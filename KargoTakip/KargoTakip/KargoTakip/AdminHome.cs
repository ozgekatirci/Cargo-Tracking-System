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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void labelBackToStart_Click(object sender, EventArgs e)
        {
            StartScreen a = new StartScreen();
            AdminOptions anaform = (AdminOptions)Application.OpenForms["AdminOptions"]; //bunun kullan o zaman işini görür
            anaform.Hide();
            a.Show();
        }
    }
}
