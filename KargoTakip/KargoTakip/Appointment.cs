using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip
{
    public class Appointment
    {
        private string UserName;
        private string TrackingNo;
        private DateTime Date;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string TrackingNo1 { get => TrackingNo; set => TrackingNo = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
    }
}
