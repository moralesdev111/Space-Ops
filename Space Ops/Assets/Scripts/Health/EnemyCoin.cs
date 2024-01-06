using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCoin : MonoBehaviour
{
    [SerializeField] EnemyHealth enemyHealth;
    [SerializeField] BankManager bankManager;
  
    void Update()
    {
        AddCoinOnKill();
    }

    private void AddCoinOnKill()
    {        
        if (enemyHealth.Die())
        {   
            if(bankManager.canUpdateCoin)
            {
                bankManager.AddBalance(1);
                bankManager.ResetCoinOperations();                   
            }                    
        }                      
    }
}
