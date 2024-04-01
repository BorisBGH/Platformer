using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour
{
    public Gun[] Guns;
    public int CurrentGunIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        TakeGunByIndex(0);
    }

    public void TakeGunByIndex(int index)
    {
        CurrentGunIndex = index;
        for (int i = 0; i < Guns.Length; i++)
        {
            if (i == index)
            {
                Guns[i].Activate();
            }
            else
            {
                Guns[i].Deactivate();
            }
        }

    }

    public void AddBullets(int gunIndex, int bulletsNumber)
    {
        Guns[gunIndex].AddBullets(bulletsNumber);
    }

   
}
