using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerLevelManager : MonoBehaviour
{
    private int currentLevel = 1;
    private int currentEXP;

    [SerializeField]
    private UnityEvent UpgradeEvent;
    
    public void AddExp(int exp)
    {
        currentEXP += exp;
    }

    public void Upgrade()
    {
        
    }
}
