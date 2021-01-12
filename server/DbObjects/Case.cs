using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "case")]
    public class Case
    {
        [XmlAttribute(AttributeName = "versions")]
        public string Versions { get; set; }
    }

}