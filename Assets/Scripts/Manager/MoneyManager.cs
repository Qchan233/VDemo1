using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int _currentCoins;
    private static MoneyManager _instance;
    [SerializeField] private PlayerData_SO playerdata;
    
    public static int Money
    {
        get { return _instance._currentCoins; }
        set { _instance._currentCoins = value; }
    }

    private void Awake()
    {
        _instance = this;
    } 
}
