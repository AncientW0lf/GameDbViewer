using System.Xml.Serialization;
using System;

namespace GameDbViewer
{
    [Serializable]
    [XmlRoot("company")]
    public class Company
    {
        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}