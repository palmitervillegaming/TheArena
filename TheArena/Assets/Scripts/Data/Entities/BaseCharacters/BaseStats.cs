﻿using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System;

[Serializable]
public class BaseStats
{
    [XmlAttribute("BaseHP")]
    public int BaseHP
    {
        get; set;
    }

    [XmlAttribute("BaseATK")]
    public int BaseATK
    {
        get;set;
    }

    [XmlAttribute("BaseSTR")]
    public int BaseSTR
    {
        get; set;
    }

    [XmlAttribute("BaseINT")]
    public int BaseINT
    {
        get; set;
    }

    [XmlAttribute("BaseMP")]
    public int BaseMP
    {
        get;set;
    }
    [XmlAttribute("BaseSTM")]
    public int BaseSTM
    {
        get; set;
    }

    [XmlAttribute("BaseFOC")]
    public int BaseFOC
    {
        get; set;
    }
}
