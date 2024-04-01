using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChargeImage : MonoBehaviour
{
    [SerializeField] private Image _backroundImage;
    [SerializeField] private Image _foregroundImage;
    [SerializeField] private TextMeshProUGUI _secondsText;


    public void StartCharge()
    {
        _backroundImage.color = new Color(1, 1, 1, 0.2f);
        _foregroundImage.enabled = true;
        _secondsText.enabled = true;
    }

    public void StopCharge()
    {
        _foregroundImage.enabled = false;
        _secondsText.enabled = false;
        _backroundImage.color = new Color(1, 1, 1, 1);
    }

    public void SetChargeValue(float currentCharge, float maxCharge)
    {
        _foregroundImage.fillAmount = currentCharge/maxCharge;
        _secondsText.text = Mathf.Ceil(maxCharge - currentCharge).ToString();
    }
}
