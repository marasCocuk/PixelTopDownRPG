using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ahmet.Attacks
{
    public abstract class Attack
    {
        public string attackName;
        public int attackPower;

        public Attack(int attackPower, string attackName)
        {
            this.attackPower = attackPower;
        }
        virtual public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }

    }
}
