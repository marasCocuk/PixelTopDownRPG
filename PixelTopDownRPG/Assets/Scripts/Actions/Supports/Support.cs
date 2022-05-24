using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Actions.Support
{
    public abstract class Support : Action
    {
        protected int supportPower;
        public string SupportName
        {
            get => name;
            set => name = value;
        }
        public int SupportPower
        {
            get => supportPower;
            set => supportPower = value;
        }
    }
}

