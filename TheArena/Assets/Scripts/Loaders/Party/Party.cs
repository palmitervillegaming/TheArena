using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System;
using Loaders.Players;

namespace Loaders.Party {

    public class Party
    {
        public const sbyte MAX_PARTY_SIZE = 6;

        public Ally[] CharacterConfiguration = new Ally[MAX_PARTY_SIZE];

        public Player CurrentPlayer;
    }

}
