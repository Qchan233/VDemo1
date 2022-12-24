using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Enemy_SO enemyData;
    [SerializeField] private UnityEvent<int> healthChanged;
    private int currentHealth;
    
    private void Awake()
    {
        currentHealth = enemyData.maxHealth;
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        healthChanged.Invoke(currentHealth);
    }
    
}
