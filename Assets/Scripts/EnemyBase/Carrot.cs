using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    private Transform _playerTransform;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _speed;
    private Vector3 _dirToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.identity;
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
        _dirToPlayer = (_playerTransform.position - transform.position).normalized;
    }


    private void FixedUpdate()
    {
        _rigidBody.AddForce(_dirToPlayer * _speed, ForceMode.VelocityChange);
    }
}
