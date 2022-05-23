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
    public partial class AdminSupport : Form
    {
        public AdminSupport()
        {
            InitializeComponent();
        }

        private void AdminSupport_Load(object sender, EventArgs e)
        {
            listViewSupport.View = View.Details;
            listViewSupport.FullRowSelect = true;   

            
            Program.supports = xmlSupport.readXMLFile();
            foreach (var support in Program.supports)
            {
                
                string[] bilgiler = { support.Name, support.Text,support.State };

                    listViewSupport.Items.Add(new ListViewItem(bilgiler));
              
            }

            for (int i = 0; i < listViewSupport.Items.Count; i++)
            {
                if( listViewSupport.Items[i].SubItems[2].Text == "Değerlendirildi")
                {
                    listViewSupport.Items[i].BackColor = Color.Green;
                }
            }
        }

        private void buttonStateChange_Click(object sender, EventArgs e)
        {
            //control if any item is selected
            if (listViewSupport.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Seçili şikayet yok");
                return;
            }
            //changes selected item's state to "evaluated"
            listViewSupport.SelectedItems[0].SubItems[2].Text = "Değerlendirildi";
            listViewSupport.SelectedItems[0].BackColor = Color.Green;

            //change from list
            foreach (var support in Program.supports)
            {
                if (listViewSupport.SelectedItems[0].SubItems[1].Text == support.Text)
                {
                    support.State =  "Değerlendirildi";                  
                }           
            }
            //datas update from xml file
            xmlSupport.updateXmlFile();

        }
    }
}
