using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _speed;
    [SerializeField] float _friction;
    [SerializeField] float _jumpSpeed;
    [SerializeField] float _maxSpeedX;
    [SerializeField] private Transform _colliderTransform;
    [SerializeField] private float _scaleRate;
    private bool _isGrounded;

    private void Start()
    {
        _isGrounded = true;
    }

    void Update()
    {
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.AddForce(0, _jumpSpeed, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.S) || !_isGrounded)
        {
            _colliderTransform.localScale = Vector3.Lerp(_colliderTransform.localScale, new Vector3(1, 0.5f, 1), Time.deltaTime * _scaleRate);
        }
        else
        {
            _colliderTransform.localScale = Vector3.Lerp(_colliderTransform.localScale, new Vector3(1, 1, 1), Time.deltaTime * _scaleRate);
        }
    }

    private void FixedUpdate()
    {

        float _speedMultiplier = 1;
        if (!_isGrounded)
        {
            _speedMultiplier = 0.1f;
            if ((_rigidBody.velocity.x > _maxSpeedX && Input.GetAxis("Horizontal") > 0) || (_rigidBody.velocity.x < -_maxSpeedX && Input.GetAxis("Horizontal") < 0))
            {

                _speedMultiplier = 0;


                Debug.Log(_rigidBody.velocity.x);

            }
        }
        _rigidBody.AddForce(Input.GetAxis("Horizontal") * _speed * _speedMultiplier, 0, 0, ForceMode.VelocityChange);

        if (_isGrounded)
        {
            _rigidBody.AddForce(-_rigidBody.velocity.x * _friction, 0, 0, ForceMode.VelocityChange);
        }

        //if (Mathf.Abs(_rigidBody.velocity.x) > _maxSpeedX && Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        //{
        //    _speedMultiplier = 0;
        //}

        
    }
    private void OnCollisionStay(Collision collision)
    {
        float angle = Vector3.Angle(collision.contacts[0].normal, Vector3.up);
        if (angle < 45)
        {
            _isGrounded = true;
        }

        //Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal * 100, Color.cyan);
        //Debug.DrawRay(collision.contacts[0].point, Vector3.up * 100, Color.green);
    }

    private void OnCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }

}
