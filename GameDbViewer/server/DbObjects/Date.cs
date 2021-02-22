using System.Xml.Serialization;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "date")]
    public class Date
    {
        [XmlAttribute(AttributeName = "year")]
        public string Year { get; set; }
        [XmlAttribute(AttributeName = "month")]
        public string Month { get; set; }
        [XmlAttribute(AttributeName = "day")]
        public string Day { get; set; }
    }

}