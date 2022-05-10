using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Actions.Attacks
{
    public class LightningAttack : MagicalAttack
    {
        public LightningAttack(int attackPower, string attackName) : base(attackPower, attackName)
        {

        }
        override public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }
    }

}
