using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 5;
    [SerializeField] private int _maxHealth = 8;
   // [SerializeField] private AudioSource _takeDamageSound;
    [SerializeField] private AudioSource _addHealthSound;
    [SerializeField] private HealthUI _healthUI;
  //  [SerializeField] private DamageScreen _damageScreen;
   // [SerializeField] private Blink _blink;
    [SerializeField] private UnityEvent _eventOnTakeDamage;
    private bool _invulnerable;

    private void Start()
    {
        _healthUI.SetUp(_maxHealth);
        _healthUI.DisplayHealth(_health);
    }

    public void TakeDamage(int damage)
    {
        if (!_invulnerable)
        {
            _health -= damage;
           // _takeDamageSound.Play();
            _healthUI.DisplayHealth(_health);
           // _damageScreen.StartEffect();
           // _blink.StartBlink();
           _eventOnTakeDamage.Invoke();
            
            if (_health <= 0)
            {
                _health = 0;
                Die();
            }
          
            Invoke(nameof(MakeVulnerable), 1f);
        }
    }

    public void AddHealth(int healthValue)
    {
        _health += healthValue;
        _addHealthSound.Play();
        _healthUI.DisplayHealth(_health);
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }

    }

    private void Die()
    {
        Debug.Log("U losse");
    }

    private void MakeVulnerable()
    {
        _invulnerable = false;
    }

}
