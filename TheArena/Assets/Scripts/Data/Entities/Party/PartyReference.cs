using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Assets.Scripts.Data.Entities.Party
{
    [Serializable]
    public class PartyReference
    {
        [XmlElement("CharacterCode")]
        public BaseCharacterRepository.CharacterCode Code;

        [XmlAttribute("Position")]
        public int Position;

        [XmlAttribute("IsActivePlayer")]
        public bool IsCurrentPlayer;

        [XmlAttribute("X")]
        public float X;

        [XmlAttribute("Y")]
        public float Y;
    }
}
