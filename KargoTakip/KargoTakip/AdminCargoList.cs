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
    public partial class AdminCargoList : UserControl
    {
        public AdminCargoList()
        {
            InitializeComponent();
            //to listview design
            listViewCargos.View = View.Details;
            listViewCargos.FullRowSelect = true;
            listViewCargos.Scrollable = true;

            //to save datas to listview.
            foreach (var cargo in Program.cargoInfos)
            {
                string a, b;
                a = cargo.DeliveryType == false ? "Şubeye Teslim" : "Adrese Teslim";
                b = cargo.PaymentType == false ? "Gönderici" : "Alıcı";
                string[] bilgiler = {cargo.UserName,cargo.CargoTrackingNo.ToString(),cargo.CargoState,
                        cargo.CargoSentProvince,cargo.CargoReceiveProvince,cargo.CurrentLocation, cargo.CargoSentDate.ToString(),
                        cargo.CargoReceiveDate.ToString(), a,b,cargo.Receiver,cargo.EstimateDeliveryDate.ToString(),cargo.CargoType,cargo.CargoWeight.ToString() };

                listViewCargos.Items.Add(new ListViewItem(bilgiler));
            }
        }
    }
}
