using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGun : MonoBehaviour
{
    [SerializeField] private Rigidbody _payerRigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private Gun _pistol;
    [SerializeField] private float _maxCharge = 3f;
    [SerializeField] private float _currentCharge;
    [SerializeField] private ChargeImage _chargeImage;
    private bool _isCharged;

    void Update()
    {
        if (_isCharged)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                _payerRigidBody.AddForce(-_spawnTransform.forward * _speed, ForceMode.VelocityChange);
                _pistol.Shot();
                _currentCharge = 0;
                _isCharged = false;
                _chargeImage.StartCharge();
            }
        }
        else
        {
            _currentCharge += Time.unscaledDeltaTime;
            _chargeImage.SetChargeValue(_currentCharge, _maxCharge);
            if (_currentCharge >= _maxCharge)
            {
                _isCharged = true;
                _chargeImage.StopCharge();
            }
        }
    }
}
