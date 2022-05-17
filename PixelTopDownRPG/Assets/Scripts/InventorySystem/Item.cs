using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventorySystem
{
    public abstract class Item
    {
        public string name;
        public int price;

        public virtual void ExecuteItem()
        {
        }
    }
}