using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace KargoTakip
{
    public partial class AdminStaffInfos : Form
    {
        public AdminStaffInfos()
        {
            InitializeComponent();
            listViewStaff.FullRowSelect = true;
            foreach (var item in Program.staffInfos)
            {
                string[] bilgiler = {  item.StaffName, item.StafId.ToString(), item.StaffJob, item.StaffStartTime.ToString() };
                listViewStaff.Items.Add(new ListViewItem(bilgiler));
            }

        }
      
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxNameSurname.Text==""  || textBoxId.Text=="" || textBoxJob.Text=="")
            {
                MessageBox.Show("Lütfen bilgileri eksiz giriniz.");
                return;
            }
            string[] row = { textBoxNameSurname.Text, textBoxId.Text, textBoxJob.Text, dateTimePicker1.Text };
            var satir = new ListViewItem(row);
            listViewStaff.Items.Add(satir);

            Program.staffInfos.Add(new StaffInfo
            {
                StaffName = textBoxNameSurname.Text,
                StafId = textBoxId.Text,
                StaffJob = textBoxJob.Text,
                StaffStartTime = dateTimePicker1.Value
            });
            xmlStaffFile.saveXMLFile(Program.staffInfos[Program.staffInfos.Count() - 1]);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Seçili personel yok");
                return;
            }
            //delete from list.
            foreach (var item in Program.staffInfos.ToList())
            {
                if (item.StafId == listViewStaff.SelectedItems[0].SubItems[1].Text)
                {
                    Program.staffInfos.Remove(item);
                }
            }
            listViewStaff.Items.Remove(listViewStaff.SelectedItems[0]);//delete from listview
            //update changes on xml file.
            xmlStaffFile.updateXmlFile();

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Seçili personel yok");
                return;
            }
            try
            {
                string staffName = Interaction.InputBox("Personel İsim Soyisim'ini giriniz.", "Veri Güncelleme", "", 100, 100);
                string staffId = Interaction.InputBox("Personel Tc Kimlik Numarasını giriniz.", "Veri Güncelleme", "", 100, 100);
                string staffJob = Interaction.InputBox("Personel görevini giriniz.", "Veri Güncelleme", "", 100, 100);
                string staffStartDate = Interaction.InputBox("Personel işe başlayış tarihi giriniz.(örn:20 Mayıs  2021 Perşembe)", "Veri Güncelleme", "", 100, 100);
               
                //delete from list.
                foreach (var item in Program.staffInfos)
                {
                    if (item.StafId == listViewStaff.SelectedItems[0].SubItems[1].Text)
                    {
                        item.StaffName = staffName;
                        item.StafId = staffId;
                        item.StaffJob = staffJob;
                        item.StaffStartTime = Convert.ToDateTime(staffStartDate);
                    }
                }
                                                                    
                //update changes on xml file.
                xmlStaffFile.updateXmlFile();

                //update listview.
                listViewStaff.SelectedItems[0].Text = staffName;
                listViewStaff.SelectedItems[0].SubItems[1].Text = staffId;
                listViewStaff.SelectedItems[0].SubItems[2].Text = staffJob;
                listViewStaff.SelectedItems[0].SubItems[3].Text = staffStartDate;
                MessageBox.Show("Seçilen veri güncellendi.", "Veri Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Veri güncelleme başarısız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void AdminStaffInfos_Load(object sender, EventArgs e)
        {

        }
    }
}
