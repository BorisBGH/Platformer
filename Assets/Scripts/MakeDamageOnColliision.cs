using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MakeDamageOnColliision : MonoBehaviour
{
    [SerializeField] private int _damage = 1;


    private void OnCollisionEnter(Collision collision)
    {
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null )
        {
            playerHealth.TakeDamage(_damage);
        }
    }
}
