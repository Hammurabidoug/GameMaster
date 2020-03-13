using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameMaster.Models
{
    [Serializable, XmlRoot("savingThrow")]
    public class SavingThrow
    {
        [XmlElement(ElementName = "ability")]
        public int AbilityId { get; set; }

        [XmlElement(ElementName = "modifier")]
        public int Modifier { get; set; }
    }
}
