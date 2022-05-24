using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterTypes;

namespace Actions.Attacks
{
    public abstract class Attack : Action
    {

        protected int attackPower;


        public string AttackName
        {
            get => name;
            set => name = value;
        }
        public int AttackPower
        {
            get => attackPower;
            set => attackPower = value;
        }


        public Attack(int attackPower, string attackName) : base(attackName)
        {
            this.attackPower = attackPower;

        }
    }
}