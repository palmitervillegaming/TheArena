using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System;

[Serializable]
public class Party : MonoBehaviour
{
    [XmlAttribute("MainName")]
    public string mainName;

    [XmlArray("Characters")]
    public List<Character> characters;
}
