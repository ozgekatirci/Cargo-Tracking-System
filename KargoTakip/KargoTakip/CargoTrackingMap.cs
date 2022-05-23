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
        }
       
        private void CargoTrackingMap_Load(object sender, EventArgs e)
        {
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
                    else if (item.CargoState == State.Şubede.ToString())
                    {
                        string a = item.CargoReceiveProvince + "-" + item.CargoReceiveProvince + ".PNG";

                        photoLocation = Path.Combine(Environment.CurrentDirectory, @"Maps", a);
                    }
                    else
                    {
                        MessageBox.Show("Kargo durumunuz haritada göstermeye uygun değil.");
                    }

                }

            }
            pictureBox1.ImageLocation = photoLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
