using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class ActivateByDistance : MonoBehaviour
{
    public float DistanceToActivate = 20f;
    private bool _isActive = true;
    private Activator _activator;


    private void Start()
    {
        _activator = FindObjectOfType<Activator>();
        _activator.ObjectsToActivate.Add(this);
    }

    public void CheckDistance(Vector3 playerPos)
    {
        float distanceToPlayer = Vector3.Distance(playerPos, transform.position);

        if (_isActive)
        {
            if (distanceToPlayer > DistanceToActivate + 2f)
            {
                Deactivate();
            }

        }
        else
        {
            if (distanceToPlayer < DistanceToActivate)
            {
                Activate();

            } 
        }

      
    }


    public void Activate()
    {
        gameObject.SetActive(true);
        _isActive = true;
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
        _isActive = false;
    }

    private void OnDestroy()
    {
        _activator.ObjectsToActivate.Remove(this);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.gray;
        Handles.DrawWireDisc(transform.position, Vector3.forward, DistanceToActivate);
        
    }
#endif
}
