using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotSpeed;
    private Transform _playerTransform;
    private Vector3 _toPlayer;
    private Quaternion _targetRotation;


    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _speed;
        _toPlayer = _playerTransform.position - transform.position;
        _targetRotation = Quaternion.LookRotation(_toPlayer, Vector3.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRotation, _rotSpeed * Time.deltaTime);  
    }
}
