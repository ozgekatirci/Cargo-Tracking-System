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
    public partial class UserCargoTracking : Form
    {
        public UserCargoTracking()
        {
            InitializeComponent();
            groupBoxOptions.Visible = false;
        }

        private void buttonAdminMap_Click(object sender, EventArgs e)
        {
            //open map page if CargoState is suitable
                foreach (var item in Program.cargoInfos)
                {
                    if (item.CargoTrackingNo == Int32.Parse(textBoxTrackingNo.Text))
                    {
                        if (item.CargoState == State.TeslimEdildi.ToString())
                        {
                           
                            MessageBox.Show("Kargo teslim edildi.");
                            return;
                        }
                        else if (item.CargoState == State.Hazırlanıyor.ToString())
                        {
                            MessageBox.Show("Kargo hazırlanıyor yola çıkmadı.");
                            return;
                        }
                    }
                }
                CargoTrackingMap a = new CargoTrackingMap();
                a.Show();

            }

        private void buttonQuestioning_Click(object sender, EventArgs e)
        {
            int temp = 0;
            //show cargo's info 
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == Int32.Parse(textBoxTrackingNo.Text))
                {
                    AdminCargoTracking.selectedTrackingCode = item.CargoTrackingNo;
                    labelAdress.Text = item.Adress;
                    labelAlinacakIl.Text = item.CargoReceiveProvince;
                    labelGonderilenIl.Text = item.CargoSentProvince;
                    labelState.Text = item.CargoState;
                    labelLocation.Text = item.CurrentLocation;
                    labelGonderilenTarih.Text = item.CargoSentDate.ToString();
                    labelReceiver.Text = item.Receiver.ToString();
                    temp = 1;
                    //if cargoState is "undeliverable" ask to users which state is they want
                    if (item.CargoState== State.TeslimEdilemediŞubede.ToString())
                    {
                        groupBoxOptions.Visible = true;
                    }


                }
            }
            if (temp == 0)
            {
                MessageBox.Show("Kargo takip numarasıyla eşleşen kargo bulunamadı.");
            }
        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //state change depends on user's choose
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == Int32.Parse(textBoxTrackingNo.Text))
                {
                    if (radioButtonBack.Checked == true)
                    {
                        item.CargoState = State.TesliEdilemediYolda.ToString();
                    }
                    if (radioButtonCenter.Checked == true)
                    {
                        item.CargoState = State.TeslimEdildi.ToString();
                    }
                    if (radioButtonDelivery.Checked == true)
                    {
                        item.CargoState = State.Şubede.ToString();
                    }
                }
            
            }
                   
        }
    }



    
    

      
    
}
