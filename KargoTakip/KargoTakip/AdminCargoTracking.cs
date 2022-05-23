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
    public partial class AdminCargoTracking : UserControl
    {
        public AdminCargoTracking()
        {
            InitializeComponent();
        }
        public static int selectedTrackingCode;
        private void buttonQuestioning_Click(object sender, EventArgs e)
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
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == Int32.Parse(textBoxTrackingNo.Text))
                {
                    selectedTrackingCode = item.CargoTrackingNo;
                    labelAdress.Text = item.Adress;
                    labelAlinacakIl.Text = item.CargoReceiveProvince;
                    labelGonderilenIl.Text = item.CargoSentProvince;
                    labelState.Text = item.CargoState;
                    labelLocation.Text = item.CurrentLocation;
                    labelGonderilenTarih.Text = item.CargoSentDate.ToString();
                    labelReceiver.Text = item.Receiver.ToString();
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

        private void textBoxTrackingNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
