using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controls.Scene.Menus
{
    //Controller class for the Game Menu
    //This Men = Game Menu
    //Left Panel = Menu
    //Right Panel = Sub-Menu
    public class GameMenuController : MonoBehaviour
    {

        //Always start on the Home screen of the game menu
        public static MenuInfo currentSubMenu = MenuInfo.Home;

        public Text gameDescriptionTextElement;
        public GameObject partyMenu;

        public GameObject CurrentMenu
        {
            get; set;
        }

        public void OnEnable()
        {
            //TEMP until integrated with GameControl
            GameControl.Instance.LoadParty();
        }

        public void Start()
        {
            //Always load the home screen to start
            LoadMenu(MenuType.HOME);
        }

        //Loads a menu in the left panel
        public void LoadMenu(MenuType type)
        {
            if (CurrentMenu != null)
            {
                CurrentMenu.SetActive(false);
            }

            switch(type)
            {
                case MenuType.HOME:
                    LoadHomeMenu();
                    break;
            }
            UpdateMenuDescription();
        }

        //Loads the home menu
        public void LoadHomeMenu()
        {
            currentSubMenu = MenuInfo.Home;
            partyMenu.SetActive(true);
        }

        public void UpdateMenuDescription()
        {
            gameDescriptionTextElement.text = currentSubMenu.Text;
        }

        //Enum types for menus (left panels)
        public enum MenuType
        {
            HOME
        }

        //Class for menu info
        public class MenuInfo
        {
            private MenuInfo(MenuType type, string name, string description)
            {
                Type = type;
                Name = name;
                Description = description;
            }

            public MenuType Type
            {
                get; private set;
            }

            //Sub menu name
            public String Name
            {
                get; private set;
            }

            //Sub menu description
            public String Description
            {
                get; private set;
            }

            //Actual text to display for the sub menu
            public String Text
            {
                get
                {
                    return Name + ": " + Description;
                }
            }

            //Add new sub menus here
            public static MenuInfo Home { get { return new MenuInfo(MenuType.HOME, "Home", "Party Overview"); } }
        }
    }
}
