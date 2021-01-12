using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GameDbViewer
{
    [XmlRoot(ElementName = "game")]
    public class Game
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "region")]
        public string Region { get; set; }
        [XmlElement(ElementName = "languages")]
        public string Languages { get; set; }
        [XmlElement(ElementName = "locale")]
        public List<Locale> Locale { get; set; }
        [XmlElement(ElementName = "publisher")]
        public string Publisher { get; set; }
        [XmlElement(ElementName = "date")]
        public Date Date { get; set; }
        [XmlElement(ElementName = "genre")]
        public string Genre { get; set; }
        [XmlElement(ElementName = "rating")]
        public Rating Rating { get; set; }
        [XmlElement(ElementName = "wi-fi")]
        public Wifi Wifi { get; set; }
        [XmlElement(ElementName = "input")]
        public Input Input { get; set; }
        [XmlElement(ElementName = "case")]
        public Case Case { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

}