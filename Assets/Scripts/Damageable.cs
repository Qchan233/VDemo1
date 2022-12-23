using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Damageable : MonoBehaviour
{
    [FormerlySerializedAs("status")] [SerializeField] private Health health;

    [SerializeField] private SpriteRenderer spriteRender;
    [SerializeField] private UnityEvent damaged;

    private Color _defaultColor;
    // Start is called before the first frame update
    void Awake()
    {
        _defaultColor = spriteRender.color;
    }

    public void TakeDamage(int damage)
    {
        health.DecreaseHealth(damage);
        spriteRender.DOColor(Color.red, 0.2f).SetLoops(2, LoopType.Yoyo).ChangeStartValue(_defaultColor);
        damaged.Invoke();
    }
}
