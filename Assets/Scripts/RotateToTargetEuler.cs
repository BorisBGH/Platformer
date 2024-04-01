using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTargetEuler : MonoBehaviour
{
    [SerializeField] Vector3 _leftEuler;
    [SerializeField] Vector3 _rightEuler;
    [SerializeField] float _rotSpeed;

   public void TurnLeft()
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(_leftEuler), _rotSpeed * Time.deltaTime);
    }

    public void TurnRight()
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(_rightEuler), _rotSpeed * Time.deltaTime);
    }
}
