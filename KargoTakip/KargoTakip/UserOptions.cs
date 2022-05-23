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
    public partial class UserOptions : Form
    {
        public UserOptions()
        {
            InitializeComponent();
            panel1.BackColor = AdminOptions.b;
            panel2.BackColor = AdminOptions.b;
            button1.BackColor = AdminOptions.b;
            this.BackColor = AdminOptions.b;
            UserHomes ucAB = new UserHomes();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserHome"].BringToFront();

        }
      
        System.Windows.Forms.Button oncekiButon;

        protected void renk(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = AdminOptions.b;
            btn.ForeColor = Color.Khaki;
            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Khaki;
                oncekiButon.ForeColor = AdminOptions.b;
            }
            System.Windows.Forms.Button dinamikButon = (sender as System.Windows.Forms.Button);
            oncekiButon = dinamikButon;
        }

        private void buttonAppointmentCancel_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserAppointmentCancel ucAB = new UserAppointmentCancel();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserAppointmentCancel"].BringToFront();
        }
        private void buttonFormerCargo_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserFormerCargos ucAB = new UserFormerCargos();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserFormerCargos"].BringToFront();
        }

        private void buttonCargoSend_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserCargoSends ucAB = new UserCargoSends();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserCargoSend"].BringToFront();
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserSupport ucAB = new UserSupport();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserSupport"].BringToFront();
        }
        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserAppointment ucAB = new UserAppointment();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserAppointment"].BringToFront();
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            UserHomes ucAB = new UserHomes();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserHome"].BringToFront();
        }
        private void buttonCargoTracking_Click(object sender, EventArgs e)
        {

            foreach (var item in Program.cargoInfos)
            {
                if (item.DeliveryType == false && item.CargoState == State.Şubede.ToString()) { }
                else
                {
                    var rand = new Random();
                    var bytes = new byte[5];
                    rand.NextBytes(bytes);
                    if (rand.Next() % 5 == 0 || item.CargoState == State.TeslimEdilemediŞubede.ToString() || item.CargoState == State.TesliEdilemediYolda.ToString())
                    {
                        item.CargoState = item.CargoState == State.Hazırlanıyor.ToString() ? State.Yolda.ToString() :
                        item.CargoState == State.Yolda.ToString() ? State.Şubede.ToString() :
                        item.CargoState == State.Şubede.ToString() ? State.Dağıtımda.ToString() :
                        item.CargoState == State.Dağıtımda.ToString() ? State.TeslimEdilemediŞubede.ToString() :
                        item.CargoState == State.TeslimEdilemediŞubede.ToString() ? State.TesliEdilemediYolda.ToString() :
                        item.CargoState == State.TesliEdilemediYolda.ToString() ? State.TeslimEdilemediSatıcıyaUlaştı.ToString() : State.TeslimEdilemediSatıcıyaUlaştı.ToString();
                    }
                    else
                    {
                        item.CargoState = item.CargoState == State.Hazırlanıyor.ToString() ? State.Yolda.ToString() :
                        item.CargoState == State.Yolda.ToString() ? State.Şubede.ToString() :
                        item.CargoState == State.Şubede.ToString() ? State.Dağıtımda.ToString() :
                        item.CargoState == State.Dağıtımda.ToString() ? State.TeslimEdildi.ToString() : State.TeslimEdildi.ToString();
                    }
                }

                if (item.CargoState == State.TeslimEdildi.ToString())
                {
                    item.CargoReceiveDate = item.EstimateDeliveryDate;
                }
                if (item.CargoState == State.Hazırlanıyor.ToString())
                {
                    item.CurrentLocation = item.CargoSentProvince;
                }
                else if (item.CargoState == State.Şubede.ToString())
                {
                    item.CurrentLocation = item.CargoReceiveProvince;
                }
                else if (item.CargoState == State.Dağıtımda.ToString())
                {
                    item.CurrentLocation = item.CargoReceiveProvince;
                }
                else if (item.CargoState == State.TeslimEdildi.ToString())
                {
                    item.CurrentLocation = item.CargoReceiveProvince;
                }
                else if (item.CargoState == State.Yolda.ToString())
                {
                    if (item.CargoReceiveProvince == "Ankara" && item.CargoSentProvince == "Denizli"
                        || item.CargoReceiveProvince == "Denizli" && item.CargoSentProvince == "Ankara")
                    {
                        item.CurrentLocation = "Afyonkarahisar";
                    }
                    else if (item.CargoReceiveProvince == "Ankara" && item.CargoSentProvince == "Eskişehir"
                        || item.CargoReceiveProvince == "Eskişehir" && item.CargoSentProvince == "Ankara")
                    {
                        item.CurrentLocation = "Oğlakçı";
                    }
                    else if (item.CargoReceiveProvince == "Ankara" && item.CargoSentProvince == "Malatya"
                        || item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Ankara")
                    {
                        item.CurrentLocation = "Kayseri";
                    }
                    else if (item.CargoReceiveProvince == "Ankara" && item.CargoSentProvince == "Ankara"
                        || item.CargoReceiveProvince == "Ankara" && item.CargoSentProvince == "Ankara")
                    {
                        item.CurrentLocation = "İsmet İnönü Bulvarı";
                    }
                    else if (item.CargoReceiveProvince == "Eskişehir" && item.CargoSentProvince == "Denizli"
                        || item.CargoReceiveProvince == "Denizli" && item.CargoSentProvince == "Eskişehir")
                    {
                        item.CurrentLocation = "Erenler";
                    }
                    else if (item.CargoReceiveProvince == "Eskişehir" && item.CargoSentProvince == "Malatya"
                        || item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Eskişehir")
                    {
                        item.CurrentLocation = "Kırşehir";
                    }
                    else if (item.CargoReceiveProvince == "Eskişehir" && item.CargoSentProvince == "Eskişehir"
                        || item.CargoReceiveProvince == "Eskişehir" && item.CargoSentProvince == "Eskişehir")
                    {
                        item.CurrentLocation = "Akarlar sokak";
                    }
                    else if (item.CargoReceiveProvince == "Denizli" && item.CargoSentProvince == "Malatya"
                       || item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Denizli")
                    {
                        item.CurrentLocation = "Konya";
                    }
                    else if (item.CargoReceiveProvince == "Denizli" && item.CargoSentProvince == "Malatya"
                       || item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Denizli")
                    {
                        item.CurrentLocation = "Erten Sitesi";
                    }
                    else if (item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Malatya"
                       || item.CargoReceiveProvince == "Malatya" && item.CargoSentProvince == "Malatya")
                    {
                        item.CurrentLocation = "Fahri Kayhan";
                    }

                }
            }
            xmlCargoFile.updateXmlFile();
           renk(sender, e);
            UserCargoTrackings ucAB = new UserCargoTrackings();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_UserCargoTracking"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
