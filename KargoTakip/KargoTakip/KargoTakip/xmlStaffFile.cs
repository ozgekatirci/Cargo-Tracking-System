using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace KargoTakip
{
    public class xmlStaffFile
    {
        public static void createXMLFile()
        {
            //using just if there is no xml file
            XmlTextWriter dosya = new XmlTextWriter(@"staffs.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("staffs");
            dosya.WriteEndElement();
            dosya.Close();
        }
        public static void saveXMLFile(StaffInfo staff)
        {
            //save infos to xml file
            XDocument xDoc = XDocument.Load(@"staffs.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementUser = new XElement("staff");
            XElement staffName = new XElement("staffName", staff.StaffName);
            XElement staffId = new XElement("staffId", staff.StafId);
            XElement staffJob = new XElement("staffJob", staff.StaffJob);
            XElement staffStartTime = new XElement("staffStartTime", staff.StaffStartTime);



            newElementUser.Add(staffName, staffId, staffJob, staffStartTime);
            rootElement.Add(newElementUser);

            xDoc.Save(@"staffs.xml");
        }
        public static List<StaffInfo> readXMLFile()
        {
            //read infos from xml file
            List<StaffInfo> staffs = new List<StaffInfo>();
            StaffInfo staff = new StaffInfo();
            XmlTextReader dosya = new XmlTextReader("staffs.xml");
            while (dosya.Read())
            {
                if (dosya.NodeType == XmlNodeType.Element)
                {
                    if (dosya.Name == "staffName")
                    {
                        staff.StaffName = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "staffId")
                    {
                        staff.StafId = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "staffJob")
                    {
                        staff.StaffJob = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "staffStartTime")
                    {
                        staff.StaffStartTime = Convert.ToDateTime(dosya.ReadString().ToString());
                        staffs.Add(staff);
                        staff = new StaffInfo();
                    }
                }
            }
            dosya.Close();
            return staffs;
        }

        public static void updateXmlFile()
        {
            createXMLFile();
            foreach (var item in Program.staffInfos)
            {
                saveXMLFile(item);
            }
        }

       
        
            
        
    }
}
