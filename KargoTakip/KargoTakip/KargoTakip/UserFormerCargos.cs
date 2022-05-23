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
    public partial class UserFormerCargos : Form
    {
        public UserFormerCargos()
        {
            InitializeComponent();         
        }

        private void UserFormerCargos_Load(object sender, EventArgs e)
        {
            listViewFormerCargos.View = View.Details;
            listViewFormerCargos.FullRowSelect = true;

            foreach (var cargo in Program.cargoInfos)
            {
                if (cargo.UserName == UserEnter.selectedUsername)
                {
                    if (cargo.CargoState == State.TeslimEdildi.ToString())
                    {                      
                        string[] bilgiler = {cargo.CargoTrackingNo.ToString(),
                        cargo.CargoSentProvince,cargo.CargoReceiveProvince, cargo.CargoSentDate.ToString(),
                        cargo.CargoReceiveDate.ToString(),cargo.Receiver };

                        listViewFormerCargos.Items.Add(new ListViewItem(bilgiler));
                    }                   
                }
            }
        }
    }

    
}
