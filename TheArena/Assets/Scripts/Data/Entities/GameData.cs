using Loaders.Party;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

[System.Serializable]
public class GameData
{
    [XmlAttribute(AttributeName = "CurrentParty")]
    public Party party;
}
