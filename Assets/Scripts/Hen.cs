using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speed;
    [SerializeField] private float _timeToReachSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector3 toPlayer = (_playerTransform.position - transform.position).normalized;
        Vector3 force = _rigidBody.mass * (toPlayer * _speed - _rigidBody.velocity)/ _timeToReachSpeed;

        _rigidBody.AddForce(force);
    }
}
