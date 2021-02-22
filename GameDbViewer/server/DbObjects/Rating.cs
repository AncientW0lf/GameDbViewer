using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "rating")]
    public class Rating
    {
        [XmlElement(ElementName = "descriptor")]
        public string Descriptor { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

}