using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep enemy type characters properties.
    /// </summary>
    public class EnemyDetails : CharacterDetails
    {
        public EnemyDetails(int level, int strength, int vitality, int intelligence, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100) : base(level, strength, vitality, intelligence, baseHealth = 500, baseStamina = 100, baseMagic = 0, basisXpForRequiredToLevelUp = 100)
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

    }
}