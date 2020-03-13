using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("data")]
    public class GameData
    {
        [XmlElement(ElementName = "version")]
        public int Version { get; set; }

        [XmlElement(ElementName = "uniqueID")]
        public int Id { get; set; }

        [XmlElement("campaign", typeof(Campaign))]
        public List<Campaign> Campaigns { get; set; } = new List<Campaign>();
    }
}
