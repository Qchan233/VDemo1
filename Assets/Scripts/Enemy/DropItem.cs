using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject dropitem;

    public void Drop()
    {
        Instantiate(dropitem, transform.position, quaternion.identity);
    }
}
