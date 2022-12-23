using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;

public class MagicMissle : MonoBehaviour
{
    [SerializeField] private MissleCreator creator;

    [SerializeField] private UnityEvent missleLanunch;
    // Start is called before the first frame update
    void Awake()
    {
        TimersManager.SetLoopableTimer(this, 0.5f, LaunchMissle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LaunchMissle()
    {
        creator.CreateMissle();
        missleLanunch.Invoke();
    }
}