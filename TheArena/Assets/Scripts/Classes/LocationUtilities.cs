using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes
{
    public static class LocationUtilities
    {
        public static Vector2 NextLocation(Vector2 current, Vector2 target, float spd)
        {
            return Vector2.MoveTowards(current, target, spd * Time.deltaTime);
        }
    }
}
