﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Classes.Battle
{
    public class Battle
    {
        public Dictionary<int, Enemy> enemies = new Dictionary<int, Enemy>();
        public Dictionary<int, Ally> allies = new Dictionary<int, Ally>();

    }
}
