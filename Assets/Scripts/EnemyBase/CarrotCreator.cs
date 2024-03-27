using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCreator : MonoBehaviour
{
    [SerializeField] private GameObject _carrotPref;
    [SerializeField] private Transform _carrotSpawn;

    private void Create()
    {
        Instantiate(_carrotPref, _carrotSpawn.position, Quaternion.identity);
    }
}
