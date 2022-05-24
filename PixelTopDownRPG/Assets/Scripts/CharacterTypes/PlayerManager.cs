using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actions.Attacks;
using InventorySystem;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep players properties.
    /// </summary>
    public class PlayerManager : CharacterManager
    {
        public int coin = 0;
        //public List<Item> Inventory;

        //public PlayerManager(int level, int strength, int vitality, int intelligence, int baseHealth = 500, int baseStamina = 100, int baseMagic = 0, int basisXpForRequiredToLevelUp = 100) : base(level, strength, vitality, intelligence, baseHealth = 500, baseStamina = 100, baseMagic = 0, basisXpForRequiredToLevelUp = 100)
        //{
        //}

        public new void Start()
        {
            this.intelligence = 5;
            this.strength = 5;
            this.vitality = 5;
            this.xp += 50000;
        }

        public void SpendCoin(int amount)
        {
            if (amount <= coin)
            {
                coin -= amount;
            }
        }

        public void AddCoin(int amount)
        {
            coin += amount;
        }
    }
}