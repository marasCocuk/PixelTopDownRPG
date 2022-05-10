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
            enemies = new List<GameObject>();

            CreatePlayer();
        }


        /// <summary>
        /// Adds player to scene
        /// </summary>
        void CreatePlayer()
        {
            player = new GameObject("Player");
            player.AddComponent<Player>();
            player.AddComponent<SpriteRenderer>();
            player.tag = "Player";

        }

        /// <summary>
        /// Adds entered enemies to scene. Dusmanlari sahneye ekler
        /// </summary>
        /// <param name="enemies"></param>
        void CreateEnemies(List<Enemy> enemies)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                GameObject newEnemy = new GameObject("Enemy");
                newEnemy.AddComponent<Enemy>();
                newEnemy.AddComponent<SpriteRenderer>();
                newEnemy.tag = "Enemy";
                this.enemies.Add(newEnemy);
            }
        }

    }

}
