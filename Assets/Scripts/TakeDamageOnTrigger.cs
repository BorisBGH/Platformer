using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemyHealth;
    [SerializeField] private bool _dieOnAnyTrigger;



    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.GetComponent<Bullet>())
            {
                _enemyHealth.TakeDamage(1);
            }
        }


        if (_dieOnAnyTrigger)
        {
            if (!other.isTrigger)
            {
                _enemyHealth.TakeDamage(10000);
            }

        }
    }
}
