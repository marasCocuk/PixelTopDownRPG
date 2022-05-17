using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep companion type characters properties.
    /// </summary>
    public class CompanionDetails : CharacterDetails
    {
        //public CompanionDetails(int level, int strength, int vitality, int intelligence, string name, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100) : base(level, strength, vitality, intelligence, baseHealth = 500, baseStamina = 100, baseMagic = 0, basisXpForRequiredToLevelUp = 100)
        //{
        //    this.name = name;
        //}

        public override void Death()
        {
        }
    }
}