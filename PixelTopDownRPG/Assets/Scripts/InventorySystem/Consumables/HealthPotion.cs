using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterTypes;

namespace InventorySystem.Consumables
{
    public class HealthPotion : Consumables
    {
        private int healthAmount { get; }

        public HealthPotion(int price, int healthAmount = 100)
        {
            this.name = "Health Potion";
            this.price = price;
            this.healthAmount = healthAmount;
        }

        public override void ExecuteItem(CharacterDetails character)
        {
            character.Heal(healthAmount);
        }
    }
}