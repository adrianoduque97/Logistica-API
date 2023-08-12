using System.Xml.Serialization;

namespace Logistica_Data.DataModels.SatControlModels
{

    [XmlRoot(ElementName = "Status")]
    public class StatusPlateHistory
    {

        [XmlElement(ElementName = "code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }
    }

    

    [XmlRoot(ElementName = "hst")]
    public class PlateHistory
    {

        [XmlElement(ElementName = "DateTimeGPS")]
        public string? DateTimeGPS { get; set; }

        [XmlElement(ElementName = "DateTimeServer")]
        public string? DateTimeServer { get; set; }

        [XmlElement(ElementName = "Latitude")]
        public double? Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public double? Longitude { get; set; }

        [XmlElement(ElementName = "Speed")]
        public double? Speed { get; set; }

        [XmlElement(ElementName = "Heading")]
        public string? Heading { get; set; }

        [XmlElement(ElementName = "Altitud")]
        public double? Altitud { get; set; }

        [XmlElement(ElementName = "Location")]
        public string? Location { get; set; }

        [XmlElement(ElementName = "Satellites")]
        public int? Satellites { get; set; }

        [XmlElement(ElementName = "IOState")]
        public string? IOState { get; set; }

        [XmlElement(ElementName = "EventID")]
        public int? EventID { get; set; }

        [XmlElement(ElementName = "Event")]
        public string? Event { get; set; }

        [XmlElement(ElementName = "PDI")]
        public string? PDI { get; set; }

        [XmlElement(ElementName = "ZONES")]
        public string? ZONES { get; set; }

        [XmlElement(ElementName = "FIRMWARE")]
        public string? FIRMWARE { get; set; }

        [XmlElement(ElementName = "Ignition")]
        public int? Ignition { get; set; }

        [XmlElement(ElementName = "LastOn")]
        public string? LastOn { get; set; }

        [XmlElement(ElementName = "LastOff")]
        public string? LastOff { get; set; }

        [XmlElement(ElementName = "Odometer")]
        public int? Odometer { get; set; }

    }

    [XmlRoot(ElementName = "Plate")]
    public class Plate
    {

        [XmlElement(ElementName = "hst")]
        public PlateHistory? Hst { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string? Id { get; set; }

        [XmlText]
        public string? Text { get; set; }
    }

    [XmlRoot(ElementName = "Response")]
    public class ResponsePlateHistory
    {

        [XmlElement(ElementName = "Status")]
        public StatusPlateHistory? Status { get; set; }

        [XmlElement(ElementName = "Plate")]
        public Plate? Plate { get; set; }
    }

    [XmlRoot(ElementName = "space")]
    public class BasePlateHistory
    {

        [XmlElement(ElementName = "Response")]
        public ResponsePlateHistory? Response { get; set; }
    }


}
