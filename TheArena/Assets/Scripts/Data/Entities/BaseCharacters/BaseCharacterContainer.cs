using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("BaseCharacterContainer")]
public class BaseCharacterContainer
{
    [XmlArray("BaseCharacters")]
    public BaseCharacter[] BaseCharacters
    {
        get; set;
    }
}
