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
    public partial class UserCargoTrackings : UserControl
    {
        public UserCargoTrackings()
        {
            InitializeComponent();
            this.BackColor = AdminOptions.b;
            groupBoxOptions.Visible = false;
        }

        private void buttonQuestioning_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (textBoxTrackingNo.Text == "")
            {
                MessageBox.Show("Lütfen takip kodunu giriniz.");
                return;
            }
            foreach (char chr in textBoxTrackingNo.Text)
            {
                if (!Char.IsNumber(chr))
                {
                    MessageBox.Show("Kargo takip no sayılardan oluşmalı.");
                    return;
                }
            }

            foreach (var item in Program.cargoInfos)
            {
                                //show cargo's info 
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
                    labelEstimateDeliveryDate.Text = item.EstimateDeliveryDate.ToString();
                    temp = 1;
                   

                    if (item.CargoState == State.Hazırlanıyor.ToString())
                    {
                        pictureBoxPreparing.BackColor = Color.Khaki;
                    }
                    else if (item.CargoState == State.Dağıtımda.ToString())
                    {
                        pictureBoxDelivery.BackColor = Color.Khaki;
                    }
                    else if (item.CargoState == State.Şubede.ToString())
                    {
                        pictureBoxCenter.BackColor = Color.Khaki;
                    }
                    else if (item.CargoState == State.TeslimEdildi.ToString())
                    {
                        pictureBoxDelivered.BackColor = Color.Khaki;
                    }
                    else if (item.CargoState == State.Yolda.ToString())
                    {                     
                        pictureBoxTransfer.BackColor = Color.Khaki;
                    }

                        //if cargoState is "undeliverable" ask to users which state is they want
                        if (item.CargoState == State.TeslimEdilemediŞubede.ToString())
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

        private void buttonAdminMap_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (textBoxTrackingNo.Text == "")
            {
                MessageBox.Show("Kargo takip numarasını giriniz.");
                return;
            }
            foreach (char chr in textBoxTrackingNo.Text)
            {
                if (!Char.IsNumber(chr))
                {
                    MessageBox.Show("Kargo takip no sayılardan oluşmalı.");
                    return;
                }
            }
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
                    temp = 1;
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("Kargo takip numarasıyla eşleşen kargo bulunamadı.");
            }
            else
            {
              
                MainCargoTrackingMap c = new MainCargoTrackingMap();
                c.Show();
               
            }
        }

       
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxTrackingNo.Text == "")
            {
                MessageBox.Show("Kargo takip numarasını giriniz.");
                return;
            }
            foreach (char chr in textBoxTrackingNo.Text)
            {
                if (!Char.IsNumber(chr))
                {
                    MessageBox.Show("Kargo takip no sayılardan oluşmalı.");
                    return;
                }
            }
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
            MessageBox.Show("İşleminiz kaydedildi.");            
        }

        private void textBoxTrackingNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UC_UserCargoTracking_Load(object sender, EventArgs e)
        {
            textBoxTrackingNo.Text = "";
            labelAdress.Text = "";
            labelAlinacakIl.Text = "";
            labelGonderilenIl.Text = "";
            labelState.Text = "";
            labelLocation.Text = "";
            labelGonderilenTarih.Text = "";
            labelReceiver.Text = "";
            labelEstimateDeliveryDate.Text = "";
        }
    }
}
