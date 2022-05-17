using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actions.Attacks;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep all character properties.
    /// </summary>
    public abstract class CharacterDetails : MonoBehaviour
    {
        /// <summary>
        ///Important Values
        /// </summary>

        //Health

        public int baseHealth = 500;
        public int maxHealth;
        public int currentHealth;

        //Stamina

        public int baseStamina = 100;
        public int maxStamina;
        public int currentStamina;

        //Magic

        public int baseMagic = 0;
        public int maxMagic;
        public int currentMagic;

        //Experience

        public int basisXpForRequiredToLevelUp = 100;
        public int level;
        public int xp;
        public int requiredXp;

        /// <summary>
        /// Stats
        /// </summary>

        public int strength; /*Physical attack stat, affects stamina*/
        public int vitality; /* health and defensive stat*/
        public int intelligence; /*Magic point and magic attack.*/

        /// <summary>
        /// Actions
        /// </summary>

        private List<Attack> attacks;

        public void levelUp(/*prototip*/)
        {
            if (xp >= requiredXp)
            {
                level++;
                xp = xp - requiredXp;
                UpdateMaxXp();
                UpdateHealth();
                UpdateStamina();
                UpdateMagic();
            }
        }

        /// <summary>
        /// update the max health data
        /// </summary>
        public void UpdateHealth()
        {
            maxHealth = baseHealth + (100 * level) + (500 * vitality);
        }

        /// <summary>
        /// Update the max stamina data
        /// </summary>
        public void UpdateStamina()
        {
            maxStamina = baseStamina + (100 * level) + (500 * strength);
        }

        /// <summary>
        /// Update the max magic data
        /// </summary>
        public void UpdateMagic()
        {
            maxMagic = baseMagic + (100 * level) + (500 * intelligence);
        }

        /// <summary>
        /// Max xp
        /// </summary>
        public void UpdateMaxXp()
        {
            requiredXp = basisXpForRequiredToLevelUp + (level * level * 1000);
        }

        public void Attack(Attack at)
        {
            /*Saldýrý yap*/
        }
    }
}