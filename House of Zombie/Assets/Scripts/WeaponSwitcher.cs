using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;
    void Start()
    {
        SetWeapon();
    }

    private void SetWeapon()
    {
        int weaponIndex = 0;
        foreach(Transform weapon in transform)
        {
            if (weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
