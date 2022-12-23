using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Charater")]
public class PlayerData_SO : ScriptableObject
{
    public Dictionary<string, int> intProperties = new Dictionary<string, int>();
    public Dictionary<string, float> floatProperties = new Dictionary<string, float>();
    public Dictionary<string, bool> boolProperties = new Dictionary<string, bool>();
    
}