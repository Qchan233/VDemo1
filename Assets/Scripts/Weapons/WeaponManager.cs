using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using Weapons;

public class WeaponManager: MonoBehaviour
{
    [SerializeField] private int _numAvailableWeapons;
    [SerializeField] private const int _maxAvailableWeapons = 12;
    private List<Weapon> _weaponList;

    
    public bool AddWeapon(Weapon newWeapon)
    {
        if (_weaponList.Count < _maxAvailableWeapons)
        {
            _weaponList.Add(newWeapon);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool RemoveWeapon(int index)
    {
        if (index < _weaponList.Count)
        {
            _weaponList.RemoveAt(index);
            return true;
        }
        else
        {
            return false;
        }
    }
    private void Awake()
    {
        _weaponList = new List<Weapon>();
    }
    
}