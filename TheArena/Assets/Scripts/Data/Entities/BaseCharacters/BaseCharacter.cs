using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System;

[Serializable]
public class BaseCharacter
{
    [XmlAttribute("CharacterCode")]
    public BaseCharacterRepository.CharacterCode code
    {
        get; set;
    }

    [XmlAttribute("BaseName")]
    public string BaseName
    {
        get; set;
    }

    [XmlElement("BaseStats")]
    public BaseStats BaseStats
    {
        get; set;
    }
}
