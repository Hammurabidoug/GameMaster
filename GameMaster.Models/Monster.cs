using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("monster")]
    public class Monster
    {
        [XmlElement(ElementName = "uid")]
        public int Id { get; set; }

        [XmlElement(ElementName = "src")]
        public int Source { get; set; }

        [XmlElement(ElementName = "enemy")]
        public bool IsEnemy { get; set; }

        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "size")]
        public int Size { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "alignment")]
        public string Alignment { get; set; }

        [XmlElement(ElementName = "senses")]
        public string Senses { get; set; }

        [XmlElement(ElementName = "ac")]
        public int ArmorClass { get; set; }

        [XmlElement(ElementName = "armor")]
        public string Armor { get; set; }

        [XmlElement(ElementName = "abilities")]
        public string Abilities { get; set; }

        [XmlElement(ElementName = "hpMax")]
        public int HitPointMaximum { get; set; }

        [XmlElement(ElementName = "hpCurrent")]
        public int HitPointCurrent { get; set; }

        [XmlElement(ElementName = "hd")]
        public string HitDice { get; set; }

        [XmlElement(ElementName = "speed")]
        public string Speed { get; set; }

        [XmlElement(ElementName = "languages")]
        public string Languages { get; set; }

        public override string ToString()
        {
            return $"{this.Name}:{this.Id}";
        }
    }
}
