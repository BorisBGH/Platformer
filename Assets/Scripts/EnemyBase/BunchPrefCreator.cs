using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunchPrefCreator : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform[] _ponts;



    [ContextMenu("Create")]
    public void Create()
    {
        foreach (Transform point in _ponts)
        {
            Instantiate(_prefab, point.position, point.rotation);
        }
    }
}
