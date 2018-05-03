using Assets.Scripts.Controls.Camera;
using Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loaders.Players
{
    public class Player : Ally
    {

        public Rigidbody2D rb;
        private BaseCharacter character;
        public BaseCharacter Character
        {
            get
            {
                return character;
            }
            set
            {
                character = value;
                if (character != null)
                {
                    characterName = character.BaseName;
                    currentHealth = character.BaseStats.BaseHP;
                    maxHealth = this.currentHealth;
                    currentMana = character.BaseStats.BaseMP;
                    maxMana = this.currentMana;
                    currentStamina = character.BaseStats.BaseSTM;
                    maxStamina = character.BaseStats.BaseSTM;
                    currentFocus = character.BaseStats.BaseFOC;
                    maxFocus = this.currentFocus;
                    this.atk = character.BaseStats.BaseATK;
                    this.Level = 1;
                }
            }
        }

        public bool isCurrentPlayer = false;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.transform.position = new Vector2(startX, startY);

            if (isCurrentPlayer)
            {
                gameObject.AddComponent<GameCamera>();
            }
        }

        void FixedUpdate()
        {
            if (isCurrentPlayer)
            {
                Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
                Vector2 newPosition = rb.position + velocity * Time.fixedDeltaTime;
                rb.MovePosition(newPosition);
            }
            else
            {
                //TODO make AI move player
            }
            GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
        }
    }
}
