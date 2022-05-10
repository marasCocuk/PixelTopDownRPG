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

        private void Start()
        {
            CreatePlayer();
        }



        void CreatePlayer()
        {
            player = new GameObject("Player");
            player.AddComponent<Player>();
            player.AddComponent<SpriteRenderer>();
            player.tag = "Player";

        }
        void CreateEnemies(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                GameObject newEnemy = new GameObject("Enemy");
                newEnemy.AddComponent<Enemy>();
                newEnemy.AddComponent<SpriteRenderer>();
                newEnemy.tag = "Player";
                this.enemies.Add();
            }
        }

    }

}
