using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private GameObject _healthIcon;
    [SerializeField] private List<GameObject> _healthIconsList;
    

    public void SetUp(int maxHealth)
    {
        for (int i = 0; i < maxHealth; i++)
        {
           _healthIconsList.Add(Instantiate(_healthIcon, transform));
        }
    }

    public void DisplayHealth(int health)
    {
        for (int i = 0; i < _healthIconsList.Count; i++)
        {
            if (i < health)
            {
                _healthIconsList[i].SetActive(true);
            }
            else
            {
                _healthIconsList[i].SetActive(false);
            }
        }
    }
}
