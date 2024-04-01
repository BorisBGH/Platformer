using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public enum Direction
{
    Left,
    Right
}

public class Walker : MonoBehaviour
{
    public Direction CurrentDirection;
    public UnityEvent _onLeftPointEvent;
    public UnityEvent _onRightPointEvent;
    [SerializeField] private Transform _leftPoint;
    [SerializeField] private Transform _rightPoint;
    [SerializeField] private float _speed;
    [SerializeField] private float _stopTime;
    [SerializeField] private Transform _rayStart;
    private bool _isStopped;
   

    // Start is called before the first frame update
    void Start()
    {
        _leftPoint.parent = null;
        _rightPoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isStopped)
        {
            if (CurrentDirection == Direction.Left)
            {
                transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.position += new Vector3(_speed * Time.deltaTime, 0, 0);
            }
        }

        if (transform.position.x < _leftPoint.position.x)
        {
            _isStopped = true;
            ChangeDirection();               
            Invoke(nameof(Go), _stopTime);
            _onLeftPointEvent.Invoke();

        }

        if(transform.position.x > _rightPoint.position.x)
        {
            _isStopped = true;
            ChangeDirection();
            Invoke(nameof(Go), _stopTime);
            _onRightPointEvent.Invoke();
        }

        RaycastHit hit;
        if(Physics.Raycast(_rayStart.position, Vector3.down, out hit))
        {
            transform.position = hit.point;
            
        }

    }

    private void Go()
    {
        _isStopped = false;

    }

   

    private void ChangeDirection()
    {
        if (CurrentDirection == Direction.Left)
        {
            CurrentDirection = Direction.Right;
        }
        else
        {
            CurrentDirection = Direction.Left;
        }

    }

}
