using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterTypes;

namespace Actions.Attacks
{
    public abstract class Attack : Action
    {
        string attackName;
        int attackPower;
        int staminaCost;

        public string AttackName
        {
            get => attackName;
            set => attackName = value;
        }
        public int AttackPower
        {
            get => attackPower;
            set => attackPower = value;
        }
        public int StaminaCost
        {
            get => staminaCost;
            set => staminaCost = value;
        }
        public Attack(int attackPower, string attackName) : base(attackName)
        {
            this.attackPower = attackPower;

        }
    }
}