using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScreen : MonoBehaviour
{
    [SerializeField] private Image _damageScreenImg;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(ShowDamageEffect());
        }

    }

    public IEnumerator ShowDamageEffect()
    {
        _damageScreenImg.enabled = true;
        for (float t = 1; t > 0f; t-= Time.deltaTime)
        {
            _damageScreenImg.color = new Color(1,0,0, t);
            yield return null;
        }
        _damageScreenImg.enabled = false;
    }
}
