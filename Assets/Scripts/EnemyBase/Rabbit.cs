using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public float AttackPeriod = 7f;
    [SerializeField] private Animator _animator;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > AttackPeriod)
        {
            _timer = 0;
            _animator.SetTrigger("Attack");
        }
    }
}
