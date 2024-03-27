using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemyHealth;
    [SerializeField] private bool _dieOnAnyCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bullet>())
        {
            _enemyHealth.TakeDamage(1);
        }

        if(_dieOnAnyCollision)
        {
            _enemyHealth.TakeDamage(10000);
        }
    }
}
