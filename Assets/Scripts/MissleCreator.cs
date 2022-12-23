using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleCreator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject misslePrefab;
    [SerializeField] private Transform playerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateMissle()
    {
        Instantiate(misslePrefab, playerTransform.position, Quaternion.identity);
    }
}
