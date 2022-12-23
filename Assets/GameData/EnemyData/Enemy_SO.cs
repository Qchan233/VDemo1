using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/Enemy1")]
public class Enemy_SO : ScriptableObject
{
   public int maxHealth;
   public int currentHealth;
   public float speed;
}
