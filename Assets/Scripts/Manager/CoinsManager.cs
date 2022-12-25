using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int _currentCoins;
    private static CoinsManager _instance;
    
    public static int Coins
    {
        get { return _instance._currentCoins; }
        set {  _instance._currentCoins = value; }
    }

    private void Awake()
    {
        _instance = this;
    } 
}
