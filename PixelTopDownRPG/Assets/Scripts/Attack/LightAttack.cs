using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attack
{
    public class LightAttack : MagicalAttack
    {
        public LightAttack(int attackPower) : base(attackPower)
        {

        }
        override public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }
    }

}
