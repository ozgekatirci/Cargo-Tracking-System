using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KargoTakip
{
    public partial class CargoTrackingMap : Form
    {
        public CargoTrackingMap()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            pictureBox1.Visible = false;
        }

        private void CargoTrackingMap_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps");
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");

            }
            MessageBox.Show("Konumunuz bulunuyor.");
            string photoLocation = null;
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == AdminCargoTracking.selectedTrackingCode)  
                {
                    if (item.CargoState == State.Yolda.ToString())
                    {
                       string a = item.CargoSentProvince + "-" + item.CargoReceiveProvince + ".PNG";

                       photoLocation = Path.Combine(Environment.CurrentDirectory, @"Maps", a);                     
                    }
                    else if(item.CargoState == State.Dağıtımda.ToString())
                    {
                       string a = item.CargoReceiveProvince + "-" + item.CargoReceiveProvince + ".PNG";

                       photoLocation = Path.Combine(Environment.CurrentDirectory, @"Maps", a);                       
                    }
                    
                }

            }
            pictureBox1.ImageLocation = photoLocation;
            webBrowser1.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
