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
    public partial class MainCargoTrackingMap : Form
    {
        public MainCargoTrackingMap()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://www.google.com/maps?q=");
            webBrowser.Navigate(queryaddress.ToString());
            timer1.Start();
        }
        int saniye = 80;
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye == 40){
                MapLoading b = new MapLoading();
                b.Show();
            }
            if (saniye == 0)
            {
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
