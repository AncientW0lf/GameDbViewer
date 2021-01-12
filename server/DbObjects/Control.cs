using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "control")]
    public class Control
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "required")]
        public string Required { get; set; }
    }

}