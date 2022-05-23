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
    public partial class UserAppointment : Form
    {
        public UserAppointment()
        {
            InitializeComponent();

            //To prevent unsuitable appointment hours from being selected from the radio button.
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

       
       private void buttonSave_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            //control CargoState's and give appointments according to this
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == Int32.Parse(textBoxTrackNo.Text))
                {
                    if(item.CargoState==State.TeslimEdildi.ToString()||
                        item.CargoState == State.Dağıtımda.ToString() ||
                        item.CargoState == State.TesliEdilemediYolda.ToString() ||
                        item.CargoState == State.TeslimEdilemediSatıcıyaUlaştı.ToString() ||
                        item.CargoState == State.TeslimEdilemediŞubede.ToString())
                    {
                        MessageBox.Show("Kargonuzun durumu randevu oluşturmaya uygun değil.");
                        return;
                    }
                    
                }

            }


            int saat;
            bool temp = false;

            //controlling whether tracking no is null or not.
            if (textBoxTrackNo.Text == "")
            {
                MessageBox.Show("Geçerli bir kargo takip numarası giriniz.");
                return;
            }

            //controlling whether tracking no is on the list or not.
            foreach (var item in Program.cargoInfos)
            {
                if (item.CargoTrackingNo == Int32.Parse(textBoxTrackNo.Text))
                {
                    foreach (var item2 in Program.appointmentInfos)
                    {
                        if(item2.TrackingNo1 == textBoxTrackNo.Text)
                        {
                            MessageBox.Show("Bu kargoya ait oluşturulmuş randevunuz mevcut yeni randevu oluşturmak istiyorsanız öncelikle eskisini siliniz.");
                            return;
                        }
                    }
                    temp = true;
                }

            }


            if (temp == false)
            {
                MessageBox.Show("Geçersiz Takip No");
                return;
            }
            // to assign selected datas to appointment's variables.
            appointment.UserName1 = UserEnter.selectedUsername;
            appointment.TrackingNo1 = textBoxTrackNo.Text;

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
            DateTime a = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, saat, 0, 0);
            appointment.Date1 = a;

            // to add appointment to appointment list.
            Program.appointmentInfos.Add(appointment);
            // to save appointment ınfos to xml.
            xmlAppointmentFile.saveXMLFile(appointment);
            MessageBox.Show("Randevu oluşturuldu.");

            textBoxTrackNo.Text = "";
            dateTimePicker1.Value=DateTime.Now;
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
        

        private void textBoxTrackNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //track no must be integer value.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //The appropriate appointment hours were also updated for each date change.
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            randomRadioButtonEnabled();
        }
    }
}
