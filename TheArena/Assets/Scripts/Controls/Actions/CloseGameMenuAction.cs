using Assets.Scripts.Controls.Keys;
using Assets.Scripts.Controls.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controls.Actions
{
    public class CloseGameMenuAction : Action
    {
        public void Fire()
        {
            SceneController.UnloadScene("GameMenu");
            KeyController.CurrentBinding = new OverworldKeyBinding();
        }
    }
}
