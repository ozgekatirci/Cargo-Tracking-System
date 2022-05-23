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
    public partial class UserSupport : UserControl
    {
        public UserSupport()
        {
            InitializeComponent();
            this.BackColor = AdminOptions.b;
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            if (textBoxSupport.Text == "")
            {
                MessageBox.Show("Lütfen şikayet ve önerilerinizi yazınız.");
                return;
            }
            SupportInfos s = new SupportInfos();
            s.Name = UserEnter.selectedUsername;
            s.Text = textBoxSupport.Text;
            s.State = "";
            xmlSupportFile.saveXMLFile(s);
            MessageBox.Show("Şikayetiniz gönderildi.");
            textBoxSupport.Text = "";

        }
    }
}
