using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("npc")]
    public class NonPlayerCharacter
    {
        [XmlElement(ElementName = "uid")]
        public int Id { get; set; }

        [XmlElement(ElementName = "enemy")]
        public bool IsEnemy { get; set; }

        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "alignment")]
        public string Alignment { get; set; }

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

        [XmlElement("savingThrow", typeof(SavingThrow))]
        public List<SavingThrow> SavingThrows { get; set; } = new List<SavingThrow>();

        [XmlElement("skill", typeof(Skill))]
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
