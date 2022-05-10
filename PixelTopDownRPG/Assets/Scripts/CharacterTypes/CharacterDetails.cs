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

        public int strength; /* can� ve fizksel sald�r�lar� etkileyen stat*/
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
            maxHealth = baseHealth + 500 * level + 100 * strength;
        }

        private List<Attack> attacks;
    }
}