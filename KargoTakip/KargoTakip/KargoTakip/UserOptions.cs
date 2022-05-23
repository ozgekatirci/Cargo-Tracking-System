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
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public static Form activeForm;
        public UserOptions()
        {
            InitializeComponent();


        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    //currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelLogo.BackColor = color;
                    //panelDesktopPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //panelTitleBar.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(153, 180, 209);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

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
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }


        private void buttonFormerCargo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserFormerCargos(), sender);
        }

        private void buttonCargoSend_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserCargoSend(), sender);
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserSupport(), sender);
        }
        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserAppointment(), sender);
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserHome(), sender);
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
            OpenChildForm(new KargoTakip.UserCargoTracking(), sender);
        }

        private void buttonAppointmentCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KargoTakip.UserAppointmentCancel(), sender);
        }

        private void UserOptions_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            panelDesktopPanel.Show();
            OpenChildForm(new KargoTakip.UserHome(), b);
        }
    }
}
