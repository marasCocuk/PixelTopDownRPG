using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ahmet.Attacks;

namespace Ahmet.Characters
{
    public abstract class Character : MonoBehaviour
    {
        public int baseHealth = 500;
        public int maxHealth;
        public int currentHealth;
        public int maxStamina;
        public int currentStamina;
        public int level;
        public int xp;

        /// <summary>
        /// Stats
        /// </summary>

        public int strength; /* caný ve fizksel saldýrýlarý etkileyen stat*/
        public int dexterity;
        public int wisdom;

        public void levelUp(/*prototip*/)
        {
            UpdateHealth();
        }

        /// <summary>
        /// update the max health data
        /// </summary>
        public void UpdateHealth()
        {
            maxHealth = baseHealth + (500 * level) + (100 * strength);
        }

        private List<Attack> attacks;
    }
}