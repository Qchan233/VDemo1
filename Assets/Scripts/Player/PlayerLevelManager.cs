using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerLevelManager : MonoBehaviour
{
    public static PlayerLevelManager Instance { get; private set; }
    private int currentLevel = 1;
    private int currentEXP;

    [SerializeField] private UnityEvent UpgradeEvent;

    public void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void AddExp(int exp)
    {
        currentEXP += exp;
    }

    public void Upgrade()
    {
        UpgradeEvent.Invoke();
    }
}
