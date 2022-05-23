using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace KargoTakip
{
    public class xmlAppointmentFile
    {
        public static void createXMLFile()
        {
            //using just if there is no xml file
            XmlTextWriter dosya = new XmlTextWriter(@"appointment.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("appointments");
            dosya.WriteEndElement();
            dosya.Close();
        }
        public static void saveXMLFile(Appointment apointment)
        {
            //save infos to xml file
            XDocument xDoc = XDocument.Load(@"appointment.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementUser = new XElement("appointment");
            XElement userName = new XElement("userName", apointment.UserName1);
            XElement trackingCode = new XElement("trackingCode", apointment.TrackingNo1);
            XElement date = new XElement("date", apointment.Date1);
            newElementUser.Add(userName, trackingCode, date);
            rootElement.Add(newElementUser);

            xDoc.Save(@"appointment.xml");
        }
        public static List<Appointment> readXMLFile()
        {
            //read infos from xml file
            List<Appointment> appointments = new List<Appointment>();
            Appointment appointment = new Appointment();
            XmlTextReader dosya = new XmlTextReader("appointment.xml");
            while (dosya.Read())
            {
                if (dosya.NodeType == XmlNodeType.Element)
                {
                    if (dosya.Name == "userName")
                    {
                        appointment.UserName1 = dosya.ReadString().ToString();
                    }
                    if (dosya.Name == "trackingCode")
                    {
                        appointment.TrackingNo1 = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "date")
                    {
                        appointment.Date1 = Convert.ToDateTime(dosya.ReadString().ToString());
                        appointments.Add(appointment);
                        appointment = new Appointment();
                    }
                }
            }
            dosya.Close();
            return appointments;
        }
        public static void updateXmlFile()
        {
            createXMLFile();
            foreach (var item in Program.appointmentInfos)
            {
                saveXMLFile(item);
            }
        }
    }
}
