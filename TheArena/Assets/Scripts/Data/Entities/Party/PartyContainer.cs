using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Assets.Scripts.Data.Entities.Party
{
    public class PartyContainer
    {
        [XmlArray("PartyReferences")]
        public List<PartyReference> PartyReference;
    }
}
