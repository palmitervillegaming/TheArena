using Controls;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Menus.MainMenu
{
    public class PartyCharacterWrapper : MonoBehaviour
    {
        private const String HEALTH_SEPARATOR = "/";
        private const String LEVEL_LABEL = "Level: ";

        public int location;
        private float maxWidth;

        public GameObject characterPanel;

        private Ally ally;
        public Ally Ally
        {
            get
            {
                return ally;
            }

            set
            {
                ally = value;
                nameText.text = ally.name;
                levelText.text = LEVEL_LABEL + Convert.ToString(ally.level);
                hpText.text = Convert.ToString(ally.currentHealth) + HEALTH_SEPARATOR + Convert.ToString(ally.maxHealth);
                mpText.text = Convert.ToString(ally.currentMana) + HEALTH_SEPARATOR + Convert.ToString(ally.maxMana);
                staminaText.text = Convert.ToString(ally.currentStamina) + HEALTH_SEPARATOR + Convert.ToString(ally.maxStamina);
                focusText.text = Convert.ToString(ally.currentFocus) + HEALTH_SEPARATOR + Convert.ToString(ally.maxFocus);
                hpBar.fillAmount = 1.0f * ally.currentHealth / ally.maxHealth;
                mpBar.fillAmount = 1.0f * ally.currentMana / ally.maxMana;
                stmBar.fillAmount = 1.0f * ally.currentStamina / ally.maxStamina;
                focBar.fillAmount = 1.0f * ally.currentFocus / ally.maxFocus;
                //TODO load sprite
            }
        }

        public Text nameText;
        public Text levelText;
        public Text hpText;
        public Text mpText;
        public Text staminaText;
        public Text focusText;
        public Image hpBar;
        public Image mpBar;
        public Image stmBar;
        public Image focBar;

        public void OnEnable()
        {
            LoadCharacterData();
        }

        public void LoadCharacterData()
        {
            Ally = GameControl.Instance.Party.CharacterConfiguration[location];
            characterPanel.SetActive(Ally != null);
        }
    }
}
