using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    [SerializeField] private Vector3 _leftEuler;
    [SerializeField] private Vector3 _rightEuler;
    [SerializeField] private float _rotationSpeed;
    private Transform _playerTransform;
    private Vector3 _targetRotEuler;

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.position.x < transform.position.x)
        {
            _targetRotEuler = _leftEuler;
           
        }
        else
        {
            _targetRotEuler = _rightEuler;
          
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetRotEuler), _rotationSpeed * Time.deltaTime);

    }
}
