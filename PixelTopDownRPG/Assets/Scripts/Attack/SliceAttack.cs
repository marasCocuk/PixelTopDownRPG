using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ahmet.Attacks
{
    public abstract class SliceAttack : PhysicalAttack
    {
        public SliceAttack(int attackPower, string attackName) : base(attackPower, attackName)
        {
        }
        override public void ExecuteAttack(/*Belli bir character*/)
        {
            // Karakterin canını bir miktar düşür.
        }
    }
}
