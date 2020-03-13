using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("campaign")]
    public class Campaign
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement("pc", typeof(PlayerCharacter))]
        public List<PlayerCharacter> PlayerCharacters { get; set; } = new List<PlayerCharacter>();

        [XmlElement("adventure", typeof(Adventure))]
        public List<Adventure> Adventures { get; set; } = new List<Adventure>();

        public override string ToString()
        {
            return this.Name;
        }
    }
}
