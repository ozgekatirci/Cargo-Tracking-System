using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace KargoTakip
{
    public class xmlUserFile
    {
        public static void createXMLFile()
        {
            //using just if there is no xml file
            XmlTextWriter dosya = new XmlTextWriter(@"users.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("users");
            dosya.WriteEndElement();
            dosya.Close();
        }
        public static void saveXMLFile(User user)
        {
            //save infos to xml file
            XDocument xDoc = XDocument.Load(@"users.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementUser = new XElement("user");
            XElement userID = new XElement("userID", user.Id);
            XElement userName = new XElement("userName", user.NameSurname);
            XElement userPassword = new XElement("userPassword", user.Password.ToString());
            XElement userUsename = new XElement("userUsername", user.Username);
            XElement userEmail = new XElement("userEmail", user.Email);


            newElementUser.Add(userID, userName, userPassword, userUsename, userEmail);
            rootElement.Add(newElementUser);
           
            xDoc.Save(@"users.xml");
        }
        public static List<User> readXMLFile()
        {
            //read infos from xml file
            List<User> user = new List<User>();
            User us = new User();
            KargoInfo ka = new KargoInfo();
            XmlTextReader dosya = new XmlTextReader("users.xml");
            while (dosya.Read())
            {
                if (dosya.NodeType == XmlNodeType.Element)
                {
                    if (dosya.Name == "userID")
                    {
                        us.Id = Int32.Parse(dosya.ReadString());
                    }
                    else if (dosya.Name == "userName")
                    {
                        us.NameSurname = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "userPassword")
                    {
                        us.Password = dosya.ReadString();
                    }
                    else if (dosya.Name == "userUsername")
                    {
                        us.Username = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "userEmail")
                    {
                        us.Email = dosya.ReadString().ToString();
                        user.Add(us);
                        us = new User();
                    }                  
                }

            }
            dosya.Close();
            return user;
        }
        public static void updateXmlFile()
        {
            //update infos which is in xml file
            createXMLFile();
            foreach (var item in Program.usersInfo)
            {
                saveXMLFile(item);
            }
        }
    }
}