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
    public partial class AdminOptions : Form
    {
        public AdminOptions()
        {
            InitializeComponent();
            panel1.BackColor = b;
            panel2.BackColor = b;
            button1.BackColor = b;
            this.BackColor = b;
            AdminHome ucAB = new AdminHome();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminHome"].BringToFront();
        }
        public static Color a = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]);
        public static Color b = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[1]);
        System.Windows.Forms.Button oncekiButon;

        protected void renk(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = b; 
            btn.ForeColor = Color.Khaki;
            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Khaki;
                oncekiButon.ForeColor = Color.MidnightBlue;
            }
            System.Windows.Forms.Button dinamikButon = (sender as System.Windows.Forms.Button);
            oncekiButon = dinamikButon;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            AdminHome ucAB = new AdminHome();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminHome"].BringToFront();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            //call AdminAppointment form
            AdminAppointment ucAB = new AdminAppointment();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminAppointment"].BringToFront();
        }
        private void buttonCargoList_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            AdminCargoList ucAB = new AdminCargoList();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminCargoList"].BringToFront();
        }

        private void buttonUserInfos_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            //call AdminUserInfos form
            AdminUserInfos ucAB = new AdminUserInfos();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminUserInfos"].BringToFront();
        }

        private void buttonCargoAdd_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            AdminCargoAdd ucAB = new AdminCargoAdd();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminCargoAdd"].BringToFront();
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            //call AdminSupport form
            AdminSupports ucAB = new AdminSupports();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminSupport"].BringToFront();
        }

        private void buttonStaffInfo_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            renk(sender, e);
            AdminStaffInfos ucAB = new AdminStaffInfos();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminStaffInfos"].BringToFront();
        }

        private void buttonCargoTracking_Click(object sender, EventArgs e)
        {
            foreach (var item in Program.cargoInfos)
            {
                //if DeliveryType is "center" and CargoState is also "center"
                if (item.DeliveryType == false && item.CargoState == State.Şubede.ToString()) { }
                else
                {
                    //to set Cargo state
                     item.CargoState = item.CargoState == State.Hazırlanıyor.ToString() ? State.Yolda.ToString() :
                        item.CargoState == State.Yolda.ToString() ? State.Şubede.ToString() :
                        item.CargoState == State.Şubede.ToString() ? State.Dağıtımda.ToString() :
                        item.CargoState == State.Dağıtımda.ToString() ? State.TeslimEdildi.ToString() : State.TeslimEdildi.ToString();
                }


                if (item.CargoState == State.TeslimEdildi.ToString())
                {
                    //if CargoState is "delivered", EstimateDateDeliveryDate assign to CargoReceiveDate
                    item.CargoReceiveDate = item.EstimateDeliveryDate;
                }


                //assign location according to CargoState
                if (item.CargoState == State.Hazırlanıyor.ToString())
                {
                    item.CurrentLocation = item.CargoSentProvince;
                }
                else if (item.CargoState == State.Dağıtımda.ToString())
                {
                    item.CurrentLocation = item.CargoReceiveProvince;
                }
                else if (item.CargoState == State.Şubede.ToString())
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
            //datas update from xml
            xmlCargoFile.updateXmlFile();
            //call AdminCargoTracking form
            renk(sender, e);
            AdminCargoTracking ucAB = new AdminCargoTracking();
            ucAB.Dock = DockStyle.Fill;
            panel2.Controls.Add(ucAB);
            panel2.Controls["UC_AdminCargoTracking"].BringToFront();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
