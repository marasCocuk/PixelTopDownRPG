using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Actions.Attacks
{
    public abstract class Attack : Action
    {
        public string attackName;
        public int attackPower;

        public Attack(int attackPower, string attackName) : base(attackName)
        {
            this.attackPower = attackPower;

        }

        public virtual void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }
    }
}