using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class CharacterStats
{
    [XmlAttribute("Name")]
    public string Name
    {
        get;set;
    }

    [XmlAttribute("BaseStats")]
    public BaseStats Stats
    {
        get;set;
    }
}
