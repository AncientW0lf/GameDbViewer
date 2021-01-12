using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "wi-fi")]
    public class Wifi
    {
        [XmlAttribute(AttributeName = "players")]
        public string Players { get; set; }
    }

}