using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private UnityEvent _onTakeDamageEvent;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _onTakeDamageEvent.Invoke();
        if (_health <= 0)
        {
            Die();
        }
       

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
