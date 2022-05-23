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
    public partial class AdminUserInfos : UserControl
    {
        public AdminUserInfos()
        {
            InitializeComponent();
            this.BackColor = AdminOptions.b;
            listViewUser.View = View.Details;
            listViewUser.FullRowSelect = true;
            listViewUser.Scrollable = true;

            foreach (var item in Program.usersInfo)
            {
                string[] bilgiler = { item.Id.ToString(), item.NameSurname, item.Username, item.Email };
                listViewUser.Items.Add(new ListViewItem(bilgiler));
            }
        }
        private void buttonUserDelete_Click(object sender, EventArgs e)
        {
            if (listViewUser.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Seçili personel yok");
                return;
            }
            //delete from list.
            foreach (var item in Program.usersInfo.ToList())
            {
                if (item.Username == listViewUser.SelectedItems[0].SubItems[2].Text)
                {
                    Program.usersInfo.Remove(item);
                }
            }
            listViewUser.Items.Remove(listViewUser.SelectedItems[0]);//delete from listview
            //update changes on xml file.
            xmlUserFile.updateXmlFile();
        }
    }
}
