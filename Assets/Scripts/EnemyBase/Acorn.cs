using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private float _maxAngularVelocity;
    private Rigidbody _rb;

    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddRelativeForce(_velocity, ForceMode.VelocityChange);

        _rb.angularVelocity = new Vector3(
            Random.Range(-_maxAngularVelocity, _maxAngularVelocity),
            Random.Range(-_maxAngularVelocity, _maxAngularVelocity),
            Random.Range(-_maxAngularVelocity, _maxAngularVelocity));
    }

}
