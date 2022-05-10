using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Attack
{
    public class ThrustAttack : PhysicalAttack
    {


        public ThrustAttack(int attackPower) : base(attackPower)
        {

        }
        override public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }

    }
}
