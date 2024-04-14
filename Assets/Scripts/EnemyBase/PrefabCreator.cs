using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject _pref;
    [SerializeField] private Transform _spawn;

    public void Create()
    {
        Instantiate(_pref, _spawn.position, _spawn.rotation);
    }
}
