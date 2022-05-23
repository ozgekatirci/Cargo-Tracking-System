using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace KargoTakip
{
    public partial class UserCargoSend : Form
    {
        public UserCargoSend()
        {
            InitializeComponent();          
        }
        
        private void buttonCargoSend_Click(object sender, EventArgs e)
        {
            // to checking whether the user has entered incomplete information.
            if (textBoxAdress.Text == "" || comboBoxDeliveryType.SelectedIndex == -1 || textBoxReceiver.Text == ""||
               comboBoxPaymentType.SelectedIndex == -1 || comboBoxGonderilenIl.SelectedIndex == -1 || comboBoxAlinanIl.SelectedIndex == -1
                    || textBoxWeight.Text == ""|| comboBoxCargoType.SelectedIndex == -1 )
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }

            
            //A new cargo is created to add to the cargo list and the information entered by the user is assigned to the cargo information.
            KargoInfo kargo = new KargoInfo();
            kargo.UserName = UserEnter.selectedUsername;
            kargo.CargoSentDate = dateTimePicker1.Value;
            kargo.Adress = textBoxAdress.Text;
            kargo.DeliveryType = comboBoxDeliveryType.SelectedIndex == 0 ? false : true;
            kargo.PaymentType = comboBoxPaymentType.SelectedIndex == 0 ? false : true;
            kargo.CargoSentProvince = comboBoxGonderilenIl.SelectedItem.ToString();           
            kargo.CargoReceiveProvince = comboBoxAlinanIl.SelectedItem.ToString();
            kargo.Receiver = textBoxReceiver.Text;
            kargo.CargoType = comboBoxCargoType.SelectedItem.ToString();
            kargo.CargoWeight = Convert.ToInt32(textBoxWeight.Text);
            dateTimePicker1.Value.AddDays(3);
            kargo.EstimateDeliveryDate = dateTimePicker1.Value;
            //cargo adding to cargo list and xml.

            Program.cargoInfos.Add(kargo);
            xmlCargoFile.saveXMLFile(kargo);

            //give tracking code to user.
            labelTrackNo.Text = kargo.CargoTrackingNo.ToString();

            //clear selected and entered infos.
            dateTimePicker1.Value = DateTime.Now;
            textBoxAdress.Text = "";
            comboBoxDeliveryType.SelectedIndex =-1;
            comboBoxPaymentType.SelectedIndex = -1;
            comboBoxGonderilenIl.SelectedIndex = -1;
            comboBoxAlinanIl.SelectedIndex = -1;
            textBoxReceiver.Text = "";
            comboBoxCargoType.SelectedIndex = -1;
            textBoxWeight.Text = "";




        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == "" || comboBoxDeliveryType.SelectedIndex == -1 || textBoxReceiver.Text == ""||
               comboBoxPaymentType.SelectedIndex == -1 || comboBoxGonderilenIl.SelectedIndex == -1 || comboBoxAlinanIl.SelectedIndex == -1
               || textBoxWeight.Text == "" || comboBoxCargoType.SelectedIndex == -1 )
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }
            labelPrice.Text  =  (Convert.ToInt32(textBoxWeight.Text)*5).ToString();
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            //weight must be integer.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
