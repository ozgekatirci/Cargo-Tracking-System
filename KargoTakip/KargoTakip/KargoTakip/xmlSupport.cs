using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace KargoTakip
{
    public class xmlSupport
    {
        public static void createXMLFile()
        {
            //using just if there is no xml file
            XmlTextWriter dosya = new XmlTextWriter(@"supports.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("supports");
            dosya.WriteEndElement();
            dosya.Close();
        }
        public static void saveXMLFile( SupportInfos s)
        {
            //save infos to xml file
            XDocument xDoc = XDocument.Load(@"supports.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementUser = new XElement("support");
            XElement supportName = new XElement("supportName", s.Name);
            XElement supportText = new XElement("supportText", s.Text);
            XElement supportState = new XElement("supportState", s.State);
            newElementUser.Add(supportName, supportText, supportState);
            rootElement.Add(newElementUser);

            xDoc.Save(@"supports.xml");
        }
        public static List<SupportInfos> readXMLFile()
        {
            //read infos from xml file
            List<SupportInfos> supports = new List<SupportInfos>();
            SupportInfos support = new SupportInfos();
            XmlTextReader dosya = new XmlTextReader("supports.xml");
            while (dosya.Read())
            {
                if (dosya.NodeType == XmlNodeType.Element)
                {
                    if (dosya.Name == "supportName")
                    {
                        support.Name = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "supportText")
                    {
                        support.Text = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "supportState")
                    {
                        support.State = dosya.ReadString().ToString();
                        supports.Add(support);
                        support = new SupportInfos();
                    }
                }
            }
            dosya.Close();
            return supports;
        }
        public static void updateXmlFile()
        {
            createXMLFile();
            foreach (var item in Program.supports)
            {
                saveXMLFile(item);
            }
        }
    }
}
