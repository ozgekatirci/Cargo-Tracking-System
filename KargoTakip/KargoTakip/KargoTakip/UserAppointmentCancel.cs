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
    public partial class UserAppointmentCancel : Form
    {
        public UserAppointmentCancel()
        {
            InitializeComponent();
        }

        private void buttonAppCancel_Click(object sender, EventArgs e)
        {
            //delete from list.
            foreach (var item in Program.appointmentInfos.ToList())
            {
                if (item.TrackingNo1 == listViewAppointment.SelectedItems[0].Text)
                {
                    Program.appointmentInfos.Remove(item);
                }
            }
            listViewAppointment.Items.Remove(listViewAppointment.SelectedItems[0]);//delete from listview.
            //update changes on xml file.
            xmlAppointmentFile.updateXmlFile();
        }

        private void UserCargoCancel_Load(object sender, EventArgs e)
        {
            //to listview design
            listViewAppointment.View = View.Details;
            listViewAppointment.FullRowSelect = true;

            //to save datas to listview.
            foreach (var appointment in Program.appointmentInfos)
            {
                if (appointment.UserName1 == UserEnter.selectedUsername)
                {
                    string[] infos = { appointment.TrackingNo1, appointment.Date1.ToString() };
                    listViewAppointment.Items.Add(new ListViewItem(infos));
                }       

            }
        }
    }
}
