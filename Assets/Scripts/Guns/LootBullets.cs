using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBullets : MonoBehaviour
{
    [SerializeField] private int _gunIndex;
    [SerializeField] private int _bulletsNumber;

    private void OnTriggerEnter(Collider other)
    {
        PlayerArmory playerArmory = other.attachedRigidbody.GetComponent<PlayerArmory>();

        if (playerArmory != null)
        {
            playerArmory.AddBullets(_gunIndex, _bulletsNumber);
            Destroy(gameObject);
        }
    }
}
