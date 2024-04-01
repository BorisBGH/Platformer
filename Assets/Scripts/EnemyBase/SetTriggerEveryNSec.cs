using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerEveryNSec : MonoBehaviour
{
    public float Period = 7f;
    public string TriggerName = "Attack";
    [SerializeField] private Animator _animator;
    private float _timer;

   
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > Period)
        {
            _timer = 0;
            _animator.SetTrigger(TriggerName);
        }
    }
}
