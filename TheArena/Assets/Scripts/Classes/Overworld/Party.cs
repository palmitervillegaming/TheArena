using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System;

[Serializable]
public class Party
{
    public const sbyte MAX_PARTY_SIZE = 6;

    [XmlAttribute("MainName")]
    public string mainName;

    [XmlArray("Characters")]
    public List<Character> characters;

    [XmlIgnore]
    public Ally[] CharacterConfiguration = new Ally[MAX_PARTY_SIZE];
}
