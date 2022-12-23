using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WeaponManager: MonoBehaviour
{
    [SerializeField] private int _numAvailableWeapons;
    [SerializeField] private const int _maxAvailableWeapons = 12;
    private List<Weapon> _weaponList;
    private const int NUMFIND = 3;
    
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
    
    
    
    private Vector3 LocateEnemy()
    {
        var results = new Collider2D[NUMFIND];
        Physics2D.OverlapCircleNonAlloc(transform.position, 10, results);

        foreach (var result in results)
        {
            if (result!= null && result.CompareTag("Enemy"))
            {
                return result.transform.position;
            }
        }
        return (Vector3) Random.insideUnitCircle;
    }
}