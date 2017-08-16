using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLDataSerializer<T>
{
    public string Path
    {
        get;
        set;
    }

    public XMLDataSerializer(string xmlPath)
    {
        Path = xmlPath;
    }

    public T Deserialize()
    {
        var serializer = new XmlSerializer(typeof(T));
        var stream = new FileStream(Path, FileMode.Open);
        var container = serializer.Deserialize(stream);
        stream.Close();
        return (T)container;
    }

    public void Serialize(object obj)
    {
        var serializer = new XmlSerializer(typeof(T));
        var stream = new FileStream(Path, FileMode.OpenOrCreate);
        serializer.Serialize(stream, this);
        stream.Close();
    }
}
