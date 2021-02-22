using System.Xml;
using System;
using System.Xml.Serialization;

namespace GameDbViewer
{
    [Serializable]
    [XmlRoot("datafile")]
    public class GameDb
    {
        [XmlElement("companies")]
        public Company[] Companies { get; set; }

        //TODO: Insert genres here

        //TODO: Insert descriptors here

        [XmlElement("game")]
        public Game[] Games { get; set; }

        [XmlAnyElement]
        public XmlElement[] Remaining { get; set; }
    }
}