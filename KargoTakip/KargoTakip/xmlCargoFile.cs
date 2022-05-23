using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace KargoTakip
{
    public class xmlCargoFile
    {
        public static void createXMLFile()
        {
            //using just if there is no xml file
            XmlTextWriter dosya = new XmlTextWriter(@"cargos.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("cargos");
            dosya.WriteEndElement();
            dosya.Close();
        }
        public static void saveXMLFile(KargoInfo cargo)
        {
            //save infos to xml file
            XDocument xDoc = XDocument.Load(@"cargos.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementUser = new XElement("cargo");
            XElement UserName = new XElement("UserName", cargo.UserName);
            XElement CargoTrackingNo = new XElement("CargoTrackingNo", cargo.CargoTrackingNo);
            XElement CargoState = new XElement("CargoState", cargo.CargoState);
            XElement CargoSentProvince = new XElement("CargoSentProvince", cargo.CargoSentProvince);
            XElement CargoReceiveProvince = new XElement("CargoReceiveProvince", cargo.CargoReceiveProvince);
            XElement CargoSentDate = new XElement("CargoSentDate", cargo.CargoSentDate);
            XElement CargoReceiveDate = new XElement("CargoReceiveDate", cargo.CargoReceiveDate);
            XElement DeliveryType = new XElement("DeliveryType", cargo.DeliveryType);
            XElement PaymentType = new XElement("PaymentType", cargo.PaymentType);
            XElement CurrentLocation = new XElement("CurrentLocation", cargo.CurrentLocation);
            XElement Adress = new XElement("Adress", cargo.Adress);
            XElement CargoWeight = new XElement("CargoWeight", cargo.CargoWeight);
            XElement EstimateDeliveryDate = new XElement("EstimateDeliveryDate", cargo.EstimateDeliveryDate);
            XElement Receiver = new XElement("Receiver", cargo.Receiver);
            XElement CargoType = new XElement("CargoType", cargo.CargoType);
            

            newElementUser.Add(UserName, CargoTrackingNo, CargoState, CargoSentProvince,
                               CargoReceiveProvince, CargoSentDate, CargoReceiveDate, DeliveryType,
                               PaymentType, CurrentLocation, Adress, CargoWeight, EstimateDeliveryDate, Receiver, CargoType);
            rootElement.Add(newElementUser);

            xDoc.Save(@"cargos.xml");
        }
        public static List<KargoInfo> readXMLFile()
        {
            //read infos from xml file
            List<KargoInfo> cargos = new List<KargoInfo>();
            User user = new User();
            KargoInfo cargo = new KargoInfo();
            XmlTextReader dosya = new XmlTextReader("cargos.xml");
            while (dosya.Read())
            {
                if (dosya.NodeType == XmlNodeType.Element)
                {
                    if (dosya.Name == "UserName")
                    {
                        cargo.UserName = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "CargoTrackingNo")
                    {
                        cargo.CargoTrackingNo = Convert.ToInt32(dosya.ReadString().ToString());
                    }
                    else if (dosya.Name == "CargoState")
                    {
                        cargo.CargoState = dosya.ReadString().ToString();
                    }                  
                    else if (dosya.Name == "CargoSentProvince")
                    {
                        cargo.CargoSentProvince = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "CargoReceiveProvince")
                    {
                        cargo.CargoReceiveProvince = dosya.ReadString().ToString();
                    }
                    else if (dosya.Name == "CargoSentDate")
                    {
                        cargo.CargoSentDate = Convert.ToDateTime(dosya.ReadString());
                    }
                    else if (dosya.Name == "CargoReceiveDate")
                    {
                        cargo.CargoReceiveDate = Convert.ToDateTime(dosya.ReadString());
                    }
                    else if (dosya.Name == "DeliveryType")
                    {
                        cargo.DeliveryType = Boolean.Parse(dosya.ReadString());
                    }
                    else if (dosya.Name == "PaymentType")
                    {
                        cargo.PaymentType = Boolean.Parse(dosya.ReadString());
                    }
                    else if (dosya.Name == "Adress")
                    {
                        cargo.Adress = dosya.ReadString();
                    }
                    else if (dosya.Name == "CurrentLocation")
                    {
                        cargo.CurrentLocation = dosya.ReadString().ToString();                     
                    }
                    else if (dosya.Name == "CargoWeight")
                    {
                        cargo.CargoWeight = Convert.ToInt32(dosya.ReadString());         
                    }
                    else if (dosya.Name == "EstimateDeliveryDate")
                    {
                        cargo.EstimateDeliveryDate = Convert.ToDateTime(dosya.ReadString());
                    }
                    else if (dosya.Name == "Receiver")
                    {
                        cargo.Receiver = dosya.ReadString().ToString();                        
                    }
                    else if (dosya.Name == "CargoType")
                    {
                        cargo.CargoType = dosya.ReadString().ToString();

                        cargos.Add(cargo);
                        cargo = new KargoInfo();
                    }
                }

            }
            dosya.Close();
            return cargos;
        }

        public static void updateXmlFile()
        {
            createXMLFile();
            foreach (var item in Program.cargoInfos)
            {
                saveXMLFile(item);
            }
        }
    }
}