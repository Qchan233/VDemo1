using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelFinished : MonoBehaviour
{
    [SerializeField] private UnityEvent NextLevelEvent;
    public void PopNextLevelMenu()
    {
        Debug.Log("Next Level");
    }
}
