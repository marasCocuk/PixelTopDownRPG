using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Actions
{
    public abstract class Action
    {
        protected string name;
        protected int staminaCost;
        protected int manaCost;
        public int StaminaCost
        {
            get => staminaCost;
            set => staminaCost = value;
        }
        public int ManaCost
        {
            get => manaCost;
            set => manaCost = value;
        }
        public string Name
        {
            get => name;
            set { name = value; }
        }
        public Action()
        {

        }
        public Action(string name)
        {
            Name = name;
        }
    }
}

