using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCoin : MonoBehaviour
{
    [SerializeField] EnemyHealth enemyHealth;
    [SerializeField] BankManager bankManager;

    private bool coinAdded = false; // Flag to track if the coin has been added

    void Update()
    {
        if (!coinAdded && enemyHealth.Die()) // Check if the enemy is dead and the coin hasn't been added yet
        {
            AddCoinOnKill();
            coinAdded = true; // Set the flag to true to avoid multiple coin additions
        }
    }

    private void AddCoinOnKill()
    {
        if (bankManager.coinCanBeAdded)
        {
            bankManager.AddBalance(1);
            
        }
        bankManager.coinCanBeAdded = true;
    }
}
