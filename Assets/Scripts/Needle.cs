using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    Collider weapon;

    private void Awake()
    {
        weapon = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (other.GetComponent<Enemy>() != null)
            {
                other.GetComponent<Enemy>().IsHit();
            }
        }
    }

    public void EnableWeapon()
    {
        weapon.enabled = true;
    }

    public void DisableWeapon()
    {
        weapon.enabled = false;
    }
}
