using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "locale")]
    public class Locale
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "synopsis")]
        public string Synopsis { get; set; }
        [XmlAttribute(AttributeName = "lang")]
        public string Lang { get; set; }
    }

}