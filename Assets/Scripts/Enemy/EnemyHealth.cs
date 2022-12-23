using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Enemy_SO enemyData;
    [SerializeField] private UnityEvent<int> healthChanged;
    public int HealthValue
    {
        get { return enemyData.currentHealth; }
    }

    public void DecreaseHealth(int amount)
    {
        enemyData.currentHealth -= amount;
        healthChanged.Invoke(enemyData.currentHealth);
    }
    
}
