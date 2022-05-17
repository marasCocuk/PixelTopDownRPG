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

        public int baseHealth;
        public int maxHealth;
        public int currentHealth;

        //Stamina

        public int baseStamina;
        public int maxStamina;
        public int currentStamina;

        //Magic

        public int baseMagic;
        public int maxMagic;
        public int currentMagic;

        //Experience

        public int basisXpForRequiredToLevelUp;
        public int level;
        public int xp;
        public int requiredXp;

        public int upgradePoints = 0;

        /// <summary>
        /// Stats
        /// </summary>

        public int strength; /*Physical attack stat, affects stamina*/
        public int vitality; /* health and defensive stat*/
        public int intelligence; /*Magic point and magic attack.*/

        /// <summary>
        /// Actions
        /// </summary>

        public List<Attack> attacks;

        public List<Attack> weaknesses;

        public CharacterDetails(int level, int strength, int vitality, int intelligence, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100)
        {
            this.level = level;
            this.strength = strength;
            this.vitality = vitality;
            this.intelligence = intelligence;
            this.baseHealth = baseHealth;
            this.baseStamina = baseStamina;
            this.baseMagic = baseMagic;
            this.basisXpForRequiredToLevelUp = basisXpForRequiredToLevelUp;
        }

        public void levelUp(/*prototip*/)
        {
            if (xp >= requiredXp)
            {
                level++;
                upgradePoints++;
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

        /// <summary>
        /// execute attack
        /// </summary>
        /// <param name="at">direct attack</param>
        public void Attack(Attack at)
        {
            at.ExecuteAttack();
        }

        /// <summary>
        /// Random attack
        /// </summary>
        public void RandomAttack()
        {
            int index = Random.Range(0, attacks.Count + 1);
            Attack(attacks[index]);
        }
    }
}