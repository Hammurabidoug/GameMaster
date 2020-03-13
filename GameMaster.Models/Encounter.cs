using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("encounter")]
    public class Encounter
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "archived")]
        public string IsArchived { get; set; }

        [XmlElement(ElementName = "state")]
        public int State { get; set; }

        [XmlElement(ElementName = "current")]
        public int Current { get; set; }

        [XmlElement(ElementName = "round")]
        public int Round { get; set; }

        [XmlElement("combatant", typeof(Combatant))]
        public List<Combatant> Combatants { get; set; } = new List<Combatant>();

        public override string ToString()
        {
            return this.Name;
        }
    }
}
