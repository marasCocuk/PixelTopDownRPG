using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actions.Attacks;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep players properties.
    /// </summary>
    public class PlayerDetails : CharacterDetails
    {

        public PlayerDetails(int level, int strength, int vitality, int intelligence, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100) : base(level, strength, vitality, intelligence, baseHealth = 500, baseStamina = 100, baseMagic = 0, basisXpForRequiredToLevelUp = 100)
        {

        }
    }
}

