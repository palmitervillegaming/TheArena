using Assets.Scripts.Data.Entities.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Data.Repositories
{
    class PartyRepository : Repository
    {
        public static List<PartyReference> PartyReference;
        private const string XML_PATH = "/Party.xml";
        private static bool loaded = false;

        //Load the part reference data for a part configuration
        public static List<PartyReference> LoadParty()
        {
            if (!loaded)
            {
                XMLDataSerializer<PartyContainer> serializer
                    = new XMLDataSerializer<PartyContainer>(XML_PATH_PREFIX + XML_PATH);
                PartyContainer container = serializer.Deserialize();
                PartyReference = container.PartyReference;
                loaded = true;
            }
            return PartyReference;
        }
    }
}
