using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterTypes;

namespace Actions
{
    public enum AttackType
    {
        AIR_ATTACK, CRASH_ATTACK, DARK_ATTACK, FLAME_ATTACK, LIGHT_ATTACK, MAGICAL_ATTACK, PHYSICAL_ATTACK, SLICE_ATTACK, THRUST_ATTACK, WATER_ATTACK
    }
    public abstract class Attack : Action
    {

        protected int attackPower;
        protected AttackType attackType;


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