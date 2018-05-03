using Assets.Scripts.Controls.Keys;
using Assets.Scripts.Controls.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controls.Actions
{
    public class LaunchGameMenuAction : Action
    {
        public static bool isGameMenuOpen;

        public void Fire()
        {
            SceneController.AddScene("GameMenu");
            KeyController.CurrentBinding = new GameMenuKeyBinding();
        }
    }
}
