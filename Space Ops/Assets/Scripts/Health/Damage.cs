using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] EnemyHealth enemyHealth;
    public int standardDamage = 1;

    
    public void TakeDamage(int damage)
    {
        enemyHealth.CurrentHealth -= damage;
    }
}
