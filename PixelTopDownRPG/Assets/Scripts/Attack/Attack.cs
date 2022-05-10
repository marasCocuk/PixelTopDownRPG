using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public abstract class Attack
    {
        public int attackPower;

        public Attack(int attackPower)
        {
            this.attackPower = attackPower;
        }
        virtual public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }

    }
}
