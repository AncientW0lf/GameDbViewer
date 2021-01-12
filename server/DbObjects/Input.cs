using System.Xml.Serialization;
using System.Collections.Generic;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "input")]
    public class Input
    {
        [XmlElement(ElementName = "control")]
        public List<Control> Control { get; set; }
        [XmlAttribute(AttributeName = "players")]
        public string Players { get; set; }
    }

}