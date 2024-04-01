using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public List<ActivateByDistance> ObjectsToActivate;
    private Transform _playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var enemy in ObjectsToActivate)
        {

            if (enemy != null)
            {
                enemy.CheckDistance(_playerTransform.position);
            }


        }
    }
}
