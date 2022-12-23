using System;
using System.Collections;
using System.Collections.Generic;
using Timers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    [SerializeField] private Slider ProgressBar;
    [SerializeField] private readonly int _timeTotal = 20;
    [SerializeField] private UnityEvent LevelFinishedEvent;
    private float _remainingTime;

    void Awake()
    {
        _remainingTime = _timeTotal;
        ProgressBar.maxValue = _timeTotal;
        ProgressBar.value = _timeTotal;
    }
    

    // Update is called once per frame
    void Update()
    {
        _remainingTime -= Time.deltaTime;
        ProgressBar.value = _remainingTime;

        if (_remainingTime <= 0)
        {
            LevelFinishedEvent.Invoke();
            this.enabled = false;
        }
    }
}
