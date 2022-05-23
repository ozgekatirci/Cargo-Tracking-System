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
        }
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        Color a = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[0]);
        Color b = ColorTranslator.FromHtml(ThemeColor.ThemeColorList[1]);
        System.Windows.Forms.Button oncekiButon;

        protected void renk(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = b; ;
            btn.ForeColor = Color.Khaki;
            if (oncekiButon != null)
            {
                oncekiButon.BackColor = Color.Khaki;
                oncekiButon.ForeColor = b;
            }
            System.Windows.Forms.Button dinamikButon = (sender as System.Windows.Forms.Button);
            oncekiButon = dinamikButon;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
        
                }
             
            }
           
        }
       
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                
                activeForm.Close();
                
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelAdminOptions.Controls.Add(childForm);
            this.panelAdminOptions.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }
        private void buttonCargoList_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminCargoList form
            OpenChildForm(new KargoTakip.AdminCargoList(), sender);
        }

        private void buttonUserInfos_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminUserInfos form
            OpenChildForm(new KargoTakip.AdminUserInfos(), sender);
        }

        private void buttonCargoAdd_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminCargoAdd form
            OpenChildForm(new KargoTakip.AdminCargoAdd(), sender);
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminSupport form
            OpenChildForm(new KargoTakip.AdminSupport(), sender);
        }

        private void buttonStaffInfo_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminStaffInfos form
            OpenChildForm(new KargoTakip.AdminStaffInfos(), sender);
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
            OpenChildForm(new KargoTakip.AdminCargoTracking(), sender);
        }
        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminAppointment form
            OpenChildForm(new KargoTakip.AdminAppointment(), sender);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            renk(sender, e);
            //call AdminHome form
            OpenChildForm(new KargoTakip.AdminHome(), sender);
        }

        private void AdminOptions_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            panelAdminOptions.Show();
            OpenChildForm(new KargoTakip.AdminHome(), b);
        }
    }
}
