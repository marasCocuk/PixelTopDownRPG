using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ahmet.Attacks
{
    public abstract class PhysicalAttack : Attack
    {
        public PhysicalAttack(int attackPower, string attackName) : base(attackPower, attackName)
        {

        }


    }
}
