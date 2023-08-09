using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logistica_Data.DataModels.SatControlModels
{
    [XmlRoot(ElementName = "ITEM")]
    public class Item
    {

        [XmlElement(ElementName = "VEH_ID")]
        public string? VehiculoId { get; set; }

        [XmlElement(ElementName = "CMP_ID")]
        public string? ClienteId { get; set; }

        [XmlElement(ElementName = "VEH_LCNS")]
        public string? Placa { get; set; }

        [XmlElement(ElementName = "vehDateTimeUTC")]
        public string? ZonaHoraria { get; set; }

        [XmlElement(ElementName = "DeviceID")]
        public string? DeviceID { get; set; }

        [XmlElement(ElementName = "vehNewTable")]
        public string? VehNewTable { get; set; }

        [XmlElement(ElementName = "vehDBServer")]
        public string? VehDBServer { get; set; }

        [XmlElement(ElementName = "VEH_NAM")]
        public string? VEHNAM { get; set; }

        [XmlElement(ElementName = "mltEMEI")]
        public string? MltEMEI { get; set; }

        [XmlElement(ElementName = "vehImgPath")]
        public string? VehImgPath { get; set; }

        [XmlElement(ElementName = "DefaultOdometer")]
        public string? DefaultOdometer { get; set; }
    }


    [XmlRoot(ElementName = "Status")]
    public class Status
    {

        [XmlElement(ElementName = "code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }
    }

    [XmlRoot(ElementName = "Mobile")]
    public class Mobile
    {

        [XmlElement(ElementName = "ITEM")]
        public List<Item>? Item { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class Response
    {

        [XmlElement(ElementName = "Status")]
        public Status? Status { get; set; }

        [XmlElement(ElementName = "Mobile")]
        public Mobile? Mobile { get; set; }
    }

    [XmlRoot(ElementName = "space")]
    public class BaseItems
    {

        [XmlElement(ElementName = "Response")]
        public Response? Response { get; set; }
    }


}
