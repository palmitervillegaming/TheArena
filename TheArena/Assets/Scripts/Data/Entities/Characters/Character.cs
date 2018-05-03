using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System;

[Serializable]
public class Character : BaseCharacter
{
    [XmlAttribute("Resource")]
    public String Name;

    [XmlAttribute("Position")]
    public int Position;

    [XmlAttribute("Level")]
    public int Level;
}
