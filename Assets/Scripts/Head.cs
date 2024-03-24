using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField] private Transform _headTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = _headTarget.position;  
    }
}
