using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] Damage damage;
    [SerializeField] Slider healthSlider;
    [SerializeField] int maxHealth = 5;
    private int currentHealth;
    public int CurrentHealth
    {
        get => currentHealth;
        set
        {
            currentHealth = Mathf.Clamp(value, 0, maxHealth);
            UpdateHealthUI();
        }
    }
    void Start()
    {
        SetHealthAtStart();
    }


    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {   
            damage.TakeDamage(damage.standardDamage);
        }
    }

    private void SetHealthAtStart()
    {
        CurrentHealth = maxHealth;
    }
    

    private void UpdateHealthUI()
    {
        healthSlider.value = CurrentHealth;
    }
}
