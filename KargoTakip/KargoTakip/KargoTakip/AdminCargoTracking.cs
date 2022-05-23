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
    public partial class AdminCargoTracking : Form
    {
        public AdminCargoTracking()
        {
            InitializeComponent();
        }
        public static int selectedTrackingCode;
        private void buttonQuestioning_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (textBoxTrackingNo.Text =="" )
            {
                MessageBox.Show("Lütfen takip kodunu giriniz.");
                return;
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
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("Kargo takip numarasıyla eşleşen kargo bulunamadı.");
            }
        }

        private void buttonAdminMap_Click(object sender, EventArgs e)
        {
            if (textBoxTrackingNo.Text == "")
            {
                MessageBox.Show("Lütfen takip kodunu giriniz.");
                return;
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
                }
            }
            CargoTrackingMap a = new CargoTrackingMap();
            a.Show();

        }

        private void labelLocation_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void labelReceiver_Click(object sender, EventArgs e)
        {

        }

        private void labelGonderilenTarih_Click(object sender, EventArgs e)
        {

        }

        private void labelAlinacakIl_Click(object sender, EventArgs e)
        {

        }

        private void labelGonderilenIl_Click(object sender, EventArgs e)
        {

        }

        private void labelState_Click(object sender, EventArgs e)
        {

        }

        private void labelAdress_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTrackingNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
