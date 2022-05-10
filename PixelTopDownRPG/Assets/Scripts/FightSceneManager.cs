using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ahmet.Characters;


namespace GameMaster
{
    public class FightSceneManager : MonoBehaviour
    {

        GameObject player;
        List<GameObject> enemies;




        void CreatePlayer()
        {
            player = new GameObject();
            player.AddComponent<Player>();

        }


    }

}
