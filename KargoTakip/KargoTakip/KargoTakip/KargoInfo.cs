using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip
{
    public enum State
    {
        Hazırlanıyor,
        Yolda,
        Şubede,
        Dağıtımda,
        TeslimEdildi,
        TeslimEdilemediŞubede,
        TesliEdilemediYolda,
        TeslimEdilemediSatıcıyaUlaştı
    }
    public enum Type
    {
       Zarf,
       Paket    
    }
    public class KargoInfo
    {
        private string userName;
        private string adress;
        private int cargoTrackingNo;
        private string cargoState;
        private string cargoSentProvince;
        private string cargoReceiveProvince;
        private string currentLocation;
        private DateTime cargoSentDate;
        private DateTime cargoReceiveDate;
        private bool deliveryType; //false şube teslimi, true elden teslim
        private bool paymentType; //false gönderici ödemeli, true alıcı ödemeli
        private string receiver;
        private DateTime estimateDeliveryDate;
        private int cargoWeight;
        private string cargoType;
        
        public KargoInfo()
        {
            var rand = new Random();
            var bytes = new byte[5];
            rand.NextBytes(bytes);
            CargoTrackingNo = rand.Next();
            cargoState = State.Hazırlanıyor.ToString();
        }
        public string CargoState { get => cargoState; set => cargoState = value; }
        public string CargoSentProvince { get => cargoSentProvince; set => cargoSentProvince = value; }
        public string CargoReceiveProvince { get => cargoReceiveProvince; set => cargoReceiveProvince = value; }
        public DateTime CargoSentDate { get => cargoSentDate; set => cargoSentDate = value; }
        public DateTime CargoReceiveDate { get => cargoReceiveDate; set => cargoReceiveDate = value; }
        public bool DeliveryType { get => deliveryType; set => deliveryType = value; }
        public bool PaymentType { get => paymentType; set => paymentType = value; }
        public string CurrentLocation { get => currentLocation; set => currentLocation = value; }
        public string Adress { get => adress; set => adress = value; }
        public string UserName { get => userName; set => userName = value; }
        public int CargoTrackingNo { get => cargoTrackingNo; set => cargoTrackingNo = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public DateTime EstimateDeliveryDate { get => estimateDeliveryDate; set => estimateDeliveryDate = value; }
        public int CargoWeight { get => cargoWeight; set => cargoWeight = value; }
        public string CargoType { get => cargoType; set => cargoType = value; }
    }
}
