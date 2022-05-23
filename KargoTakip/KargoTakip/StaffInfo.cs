using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip
{
    public class StaffInfo
    {
        private string staffName;
        private string stafId;
        private string staffJob;
        private DateTime staffStartTime;

        public string StaffName { get => staffName; set => staffName = value; }
        public string StafId { get => stafId; set => stafId = value; }
        public string StaffJob { get => staffJob; set => staffJob = value; }
        public DateTime StaffStartTime { get => staffStartTime; set => staffStartTime = value; }
    }
}
