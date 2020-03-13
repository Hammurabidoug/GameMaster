using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("adventure")]
    public class Adventure
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement("encounter", typeof(Encounter))]
        public List<Encounter> Encounters { get; set; } = new List<Encounter>();

        [XmlElement("npc", typeof(NonPlayerCharacter))]
        public List<NonPlayerCharacter> NonPlayerCharacters { get; set; } = new List<NonPlayerCharacter>();

        public override string ToString()
        {
            return this.Name;
        }

    }
}
