using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterTypes;

namespace InventorySystem
{
    public abstract class Item
    {
        public string name;
        public int price;
        public Sprite itemPicture;
        public int requiredLevel = 0;

        public virtual void ExecuteItem(CharacterManager character)
        {
        }
    }
}