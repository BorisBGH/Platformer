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
        if (_health <= 0)
        {
            Die();
        }
        _onTakeDamageEvent.Invoke();

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
