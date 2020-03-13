using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("combatant")]
    public class Combatant
    {
        [XmlElement(ElementName = "monster")]
        public Monster Monster { get; set; }

        public override string ToString()
        {
            return this.Monster.ToString();
        }
    }
}
