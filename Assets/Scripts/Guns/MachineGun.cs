using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MachineGun : Gun
{
    [Space(12)]
    public int BulletsNubmer;
    public TextMeshProUGUI BulletsNumberText;
    [SerializeField] private PlayerArmory _playerArmory;

    public override void Shot()
    {
        base.Shot();
        BulletsNubmer--;
        UpdateBulletsText();
        if (BulletsNubmer == 0)
        {
            TakePistol();
        }
    }

    private void UpdateBulletsText()
    {
        BulletsNumberText.text = $"Bullets: {BulletsNubmer}";
    }

    public override void Activate()
    {
        base.Activate();
        BulletsNumberText.enabled = true;
        UpdateBulletsText();
    }

    public override void Deactivate()
    {
        base.Deactivate();
        BulletsNumberText.enabled = false;
    }

    public override void AddBullets(int bulletsNumber)
    {
        base.AddBullets(bulletsNumber);
        BulletsNubmer += bulletsNumber;
        UpdateBulletsText();
        _playerArmory.TakeGunByIndex(1);
    }


    private void TakePistol()
    {
       _playerArmory.TakeGunByIndex(0);
    }
}
