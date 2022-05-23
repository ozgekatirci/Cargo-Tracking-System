using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class MapLoading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );
        public MapLoading()
        {
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            timer1.Start();
        }

        int saniye = 40;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye ==0)
            {
                timer1.Stop();
                this.Hide();
                CargoTrackingMap a = new CargoTrackingMap();
                a.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
