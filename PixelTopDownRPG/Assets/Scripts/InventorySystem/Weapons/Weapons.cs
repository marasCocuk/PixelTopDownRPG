using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actions.Support;

namespace InventorySystem.Weapons
{
    public class Weapons : Item
    {
        public int attackPower;
        public int manaCost;
        public int staminaCost;
        private int[] requiredProperties;

        private List<Support> weaponBuffs = new List<Support>();
    }
}