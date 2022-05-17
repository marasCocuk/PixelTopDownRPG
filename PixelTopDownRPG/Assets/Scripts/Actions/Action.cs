using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Actions
{
    public abstract class Action
    {
        string name;
        public string Name { get => name; set { name = value; } }
        public Action()
        {

        }
        public Action(string name)
        {
            Name = name;
        }
    }
}

