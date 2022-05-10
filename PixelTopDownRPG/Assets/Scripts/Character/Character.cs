using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ahmet.Attacks;

namespace Ahmet.Characters
{
    public abstract class Character : MonoBehaviour
    {
        public int maxHealth;
        public int currentHealth;
        public int maxStamina;
        public int currentStamina;
        public int level;
        public int xp;

        /// <summary>
        /// Stats
        /// </summary>
        public int strength;

        public int dexterity;
        public int wisdom;

        private List<Attack> attacks;
    }
}