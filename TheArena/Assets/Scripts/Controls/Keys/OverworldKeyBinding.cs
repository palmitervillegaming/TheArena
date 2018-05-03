using Assets.Scripts.Controls.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controls.Keys
{
    public class OverworldKeyBinding : KeyBinding
    {
        private static Dictionary<string, Assets.Scripts.Controls.Actions.Action> actionMap = new Dictionary<string, Assets.Scripts.Controls.Actions.Action>();

        static OverworldKeyBinding()
        {
            actionMap.Add("escape", new LaunchGameMenuAction());
        }

        public void FireAction(string key)
        {
            if (actionMap.ContainsKey(key))
            {
                actionMap[key].Fire();
            }
        }
    }
}
