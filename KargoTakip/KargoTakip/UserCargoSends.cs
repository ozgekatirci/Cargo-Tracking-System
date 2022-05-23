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
    public partial class UserCargoSends : UserControl
    {
        public UserCargoSends()
        {
            InitializeComponent();
            randomRadioButtonEnabled();
        }
        private void randomRadioButtonEnabled()
        {
            //The suitability of the appointment hours was assigned randomly to test.
            var rand = new Random();
            var bytes = new byte[3];
            rand.NextBytes(bytes);
            radioButton1.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton2.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton3.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton4.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton5.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton6.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton7.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton8.Enabled = rand.Next() % 2 == 0 ? true : false;
            radioButton9.Enabled = rand.Next() % 2 == 0 ? true : false;
        }
        private void buttonPrice_Click(object sender, EventArgs e)
        {

            if (textBoxAdress.Text == "" || comboBoxDeliveryType.SelectedIndex == -1 || textBoxReceiver.Text == "" ||
               comboBoxPaymentType.SelectedIndex == -1 || comboBoxGonderilenIl.SelectedIndex == -1 || comboBoxAlinanIl.SelectedIndex == -1
               || textBoxWeight.Text == "" || comboBoxCargoType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }
            foreach (char chr in textBoxWeight.Text)
            {
                if (!Char.IsNumber(chr))
                {
                    MessageBox.Show("Ağırlık sadece sayılardan oluşmalı.");
                    return;
                }
            }
            labelPrice.Text = (Convert.ToInt32(textBoxWeight.Text) * 5).ToString();
        }
        int saat;
        private void buttonCargoSend_Click(object sender, EventArgs e)
        {
            // to checking whether the user has entered incomplete information.
            if (textBoxAdress.Text == "" || comboBoxDeliveryType.SelectedIndex == -1 || textBoxReceiver.Text == "" ||
               comboBoxPaymentType.SelectedIndex == -1 || comboBoxGonderilenIl.SelectedIndex == -1 || comboBoxAlinanIl.SelectedIndex == -1
                    || textBoxWeight.Text == "" || comboBoxCargoType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }
         
            foreach (char chr in textBoxWeight.Text)
            {
                if (!Char.IsNumber(chr))
                {
                    MessageBox.Show("Ağırlık sadece sayılardan oluşmalı.");
                    return;
                }
            }
            //Assignment is made according to the time chosen on the radiobutton.
            saat = radioButton1.Checked ? 9 : radioButton2.Checked ? 10 :
                   radioButton3.Checked ? 11 : radioButton4.Checked ? 12 :
                   radioButton5.Checked ? 13 : radioButton6.Checked ? 14 :
                   radioButton7.Checked ? 15 : radioButton8.Checked ? 16 :
                   radioButton9.Checked ? 16 : 0;
            //controlling whether hour is selected by user or not.
            if (saat == 0)
            {
                MessageBox.Show("Lütfen bir saat seçiniz.");
                return;
            }

            //to assign data infos to appointment.
    

            //A new cargo is created to add to the cargo list and the information entered by the user is assigned to the cargo information.
            KargoInfo kargo = new KargoInfo();
            kargo.UserName = UserEnter.selectedUsername;
            DateTime a = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, saat, 0, 0);
            kargo.CargoSentDate = a;
            //kargo.CargoSentDate = dateTimePicker1.Value;
            kargo.Adress = textBoxAdress.Text;
            kargo.DeliveryType = comboBoxDeliveryType.SelectedIndex == 0 ? false : true;
            kargo.PaymentType = comboBoxPaymentType.SelectedIndex == 0 ? false : true;
            kargo.CargoSentProvince = comboBoxGonderilenIl.SelectedItem.ToString();
            kargo.CargoReceiveProvince = comboBoxAlinanIl.SelectedItem.ToString();
            kargo.Receiver = textBoxReceiver.Text;
            kargo.CargoType = comboBoxCargoType.SelectedItem.ToString();
            kargo.CargoWeight = Convert.ToInt32(textBoxWeight.Text);
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(3);
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(2);
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
            };
            kargo.EstimateDeliveryDate = dateTimePicker1.Value;
            //cargo adding to cargo list and xml.

            Program.cargoInfos.Add(kargo);
            xmlCargoFile.saveXMLFile(kargo);

            MessageBox.Show("Kurye çağrısı oluşturuldu.");
            //give tracking code to user.
            labelTrackNo.Text = kargo.CargoTrackingNo.ToString();

            //clear selected and entered infos.
            dateTimePicker1.Value = DateTime.Now;
            textBoxAdress.Text = "";
            comboBoxDeliveryType.SelectedIndex = -1;
            comboBoxPaymentType.SelectedIndex = -1;
            comboBoxGonderilenIl.SelectedIndex = -1;
            comboBoxAlinanIl.SelectedIndex = -1;
            textBoxReceiver.Text = "";
            comboBoxCargoType.SelectedIndex = -1;
            textBoxWeight.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //weight must be integer.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            randomRadioButtonEnabled();
        }
    }
}
