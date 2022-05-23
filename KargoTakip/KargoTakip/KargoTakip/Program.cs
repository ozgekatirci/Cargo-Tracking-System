using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        
        //list of datas.
        public static List<User> usersInfo = new List<User>();
        public static List<KargoInfo> cargoInfos = new List<KargoInfo>();
        public static List<Appointment> appointmentInfos = new List<Appointment>();
        public static List<SupportInfos> supports = new List<SupportInfos>();
        public static List<StaffInfo> staffInfos = new List<StaffInfo>();


        [STAThread]
        static void Main()
        {
            //create xml files.if there is no xml file activate this line
            //xmlCargoFile.createXMLFile();
            //xmlUserFile.createXMLFile();
            //xmlSupport.createXMLFile();
            //xmlStaffFile.createXMLFile();
            //xmlAppointmentFile.createXMLFile();

            //read datas from xml.
            usersInfo = xmlUserFile.readXMLFile();
            cargoInfos = xmlCargoFile.readXMLFile();
            supports = xmlSupport.readXMLFile();
            staffInfos = xmlStaffFile.readXMLFile();
            appointmentInfos = xmlAppointmentFile.readXMLFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
