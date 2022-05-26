using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Actions;
using InventorySystem.Consumables;
using InventorySystem;
using InventorySystem.Outfit;

namespace CharacterTypes
{
    /// <summary>
    /// A class that is going to keep all character properties.
    /// </summary>
    public abstract class CharacterManager : MonoBehaviour
    {
        #region Global Variables

        /// <summary>
        ///Important Values
        /// </summary>

        public string characterName;

        //Health

        public int baseHealth = 100;
        public int maxHealth;
        public int currentHealth;

        //Stamina

        public int baseStamina = 100;
        public int maxStamina;
        public int currentStamina;

        //Magic

        public int baseMagic = 0;
        public int maxMagic;
        public int currentMagic;

        //Experience

        public int basisXpForRequiredToLevelUp = 1000;
        public int level;
        public int xp;
        public int requiredXp;
        public int upgradePoints = 0;

        #endregion Global Variables

        /// <summary>
        /// Stats
        /// </summary>

        public int strength; /*Physical attack stat, affects stamina*/
        public int vitality; /* health and defensive stat*/
        public int intelligence; /*Magic point and magic attack.*/
        public int agility; /*Dodge rate*/

        /// <summary>
        /// Actions
        /// </summary>

        public List<Attack> attacks = new List<Attack>();

        public List<AttackType> weaknesses = new List<AttackType>();

        public List<Item> Inventory = new List<Item>();

        public List<Consumables> ConsumableInventory = new List<Consumables>();

        /// <summary>
        /// Equipped Items
        /// </summary>

        public void Start()
        {
            UpdateHealth();
            UpdateMagic();
            UpdateMaxXp();
            UpdateStamina();
            attacks.Add(new Attack(100, "Attack"));
        }

        public void Update()
        {
            if (xp >= requiredXp)
            {
                levelUp();
            }
        }

        #region Item

        /// <summary>
        /// Self consume item. Applies the effects to itself.
        /// </summary>
        /// <param name="index"></param>
        public void ConsumeItem(int index)
        {
            ConsumeItem(this, index);
        }

        /// We can use items on other people, between companions or ourselves. Enemies should be able to do this too.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="index"></param>
        public void ConsumeItem(CharacterManager character, int index)
        {
            ConsumableInventory[index].ExecuteItem(character);
            ConsumableInventory.RemoveAt(index);
        }

        #endregion Item

        #region Experience

        /// <summary>
        /// Character levels up
        /// </summary>
        public void levelUp(/*prototip*/)
        {
            if (xp >= requiredXp)
            {
                level++;
                upgradePoints++;
                xp = xp - requiredXp;
                UpdateMaxXp();
                UpdateHealth();
                UpdateStamina();
                UpdateMagic();

                currentHealth = maxHealth;
                currentMagic = maxMagic;
                currentStamina = maxStamina;
            }
        }

        /// <summary>
        /// update the max health data
        /// </summary>
        public void UpdateHealth()
        {
            maxHealth = baseHealth + (100 * level) + (500 * vitality);
        }

        /// <summary>
        /// Update the max stamina data
        /// </summary>
        public void UpdateStamina()
        {
            maxStamina = baseStamina + (100 * level) + (500 * strength);
        }

        /// <summary>
        /// Update the max magic data
        /// </summary>
        public void UpdateMagic()
        {
            maxMagic = baseMagic + (100 * level) + (500 * intelligence);
        }

        /// <summary>
        /// Max xp
        /// </summary>
        public void UpdateMaxXp()
        {
            requiredXp = basisXpForRequiredToLevelUp + (level * level * 1000);
        }

        #endregion Experience

        #region Attack

        /// <summary>
        /// execute attack
        /// </summary>
        /// <param name="at">direct attack</param>
        public void Attack(Attack at, CharacterManager enemy)
        {
            int totalAttackPower = 0;

            //Get the power of the attack
            totalAttackPower = at.AttackPower + GetStrengthPower();
        }

        /// <summary>
        /// Random attack
        /// </summary>
        public void RandomAttack(CharacterManager enemy)
        {
            int index = Random.Range(0, attacks.Count + 1);
            Attack(attacks[index], enemy);
        }

        /// <summary>
        /// Character Health Decrease
        /// </summary>
        /// <param name="amount"></param>
        public void TakeDamage(int amount)
        {
            UpdateHealth();
            currentHealth -= amount;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        private int GetStrengthPower()
        {
            int strengthPower = (strength * 10) + level * Random.Range(0, 21);

            return strengthPower;
        }

        public bool AttackCheck()
        {
            return false;
        }

        #endregion Attack

        /// <summary>
        /// Character health increase
        /// </summary>
        /// <param name="amount"></param>
        public void Heal(int amount)
        {
            UpdateHealth();
            currentHealth += amount;

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }
}