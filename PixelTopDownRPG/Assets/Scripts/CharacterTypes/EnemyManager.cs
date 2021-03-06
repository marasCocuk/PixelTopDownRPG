using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep enemy type characters properties.
    /// </summary>
    public class EnemyManager : CharacterManager
    {
        public enum Behaviours
        { idle, physical, magical }

        public Behaviours behaviour;

        public void ChangeBehaviour(Behaviours beh)
        {
            behaviour = beh;
        }

        //public EnemyManager(int level, int strength, int vitality, int intelligence, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100) : base(level, strength, vitality, intelligence, baseHealth = 500, baseStamina = 100, baseMagic = 0, basisXpForRequiredToLevelUp = 100)
        //{
        //}
    }
}