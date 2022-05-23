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
    public partial class AdminCargoAdd : Form
    {
        public AdminCargoAdd()
        {
            InitializeComponent();
        }

        // to checking whether the user has entered incomplete information.
        private void buttonCargoSend_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if (textBox1.Text  ==  ""  || textBoxAdress.Text == "" || comboBoxDeliveryType.SelectedIndex == -1 || textBoxProductDetails.Text == "" ||
               comboBoxPaymentType.SelectedIndex == -1 || comboBoxGonderilenIl.SelectedIndex == -1 || comboBoxAlinanIl.SelectedIndex == -1 ||
               textBoxReceiver.Text ==  ""  || comboBoxCargoType.SelectedIndex  ==  -1 || textBoxWeight.Text  ==  "")  
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                return;
            }

            foreach(var item in Program.usersInfo)
            {
                if(item.Username == textBox1.Text)
                {
                    temp = 1;
                }
            }
            if (temp==0)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
                return;
            }
            //A new cargo is created to add to the cargo list and the information entered by the user is assigned to the cargo information.
            KargoInfo kargo = new KargoInfo();
            kargo.UserName = textBox1.Text.ToString();
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
            textBox1.Text  =  "";
            dateTimePicker1.Value = DateTime.Now;
            textBoxAdress.Text = "";
            textBoxProductDetails.Text = "";
            comboBoxDeliveryType.SelectedIndex = -1;
            comboBoxPaymentType.SelectedIndex = -1;
            comboBoxGonderilenIl.SelectedIndex = -1;
            comboBoxAlinanIl.SelectedIndex = -1;
            textBoxReceiver.Text = "";
            comboBoxCargoType.SelectedIndex = -1;
            textBoxWeight.Text = "";

        }
    }
}
