using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logistica_Data.DataModels.SatControlModels
{

    [XmlRoot(ElementName = "Status")]
    public class StatusPlateZone
    {

        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }
    }

    [XmlRoot(ElementName = "zone")]
    public class PlateZone
    {

        [XmlElement(ElementName = "ZoneName")]
        public string? ZoneName { get; set; }

        [XmlElement(ElementName = "TimeInZone")]
        public int TimeInZone { get; set; }

        [XmlElement(ElementName = "DateIN")]
        public string? DateIN { get; set; }

        [XmlElement(ElementName = "LocationIN")]
        public string? LocationIN { get; set; }

        [XmlElement(ElementName = "DateOUT")]
        public string? DateOUT { get; set; }

        [XmlElement(ElementName = "LocationOUT")]
        public string? LocationOUT { get; set; }

        [XmlElement(ElementName = "Fleet")]
        public string? Fleet { get; set; }

        [XmlElement(ElementName = "Group")]
        public string? Group { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
    }

    [XmlRoot(ElementName = "Plate")]
    public class PlateBase
    {

        [XmlElement(ElementName = "zone")]
        public List<PlateZone>? Zone { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string? Id { get; set; }

        [XmlText]
        public string? Text { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class ResponsePlateZone
    {

        [XmlElement(ElementName = "Status")]
        public StatusPlateZone? Status { get; set; }

        [XmlElement(ElementName = "Plate")]
        public PlateBase? Plate { get; set; }
    }

    [XmlRoot(ElementName = "Widetech")]
    public class BasePlateZone
    {

        [XmlElement(ElementName = "Response")]
        public ResponsePlateZone? Response { get; set; }
    }


}
