using Assets.Scripts.Controls.Actions;
using System.Collections.Generic;


namespace Assets.Scripts.Controls.Keys
{
    public class GameMenuKeyBinding : KeyBinding
    {
        private static Dictionary<string, Assets.Scripts.Controls.Actions.Action> actionMap = new Dictionary<string, Assets.Scripts.Controls.Actions.Action>();

        static GameMenuKeyBinding()
        {
            actionMap.Add("escape", new CloseGameMenuAction());
        }

        public void FireAction(string key)
        {
            if (actionMap.ContainsKey(key)) {
                actionMap[key].Fire();
            }
        }
    }
}
