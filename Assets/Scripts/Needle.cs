using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    Collider weapon;
    Collider needle;
    Collider DoCollider;

    public AudioSource Do;
    public AudioSource Ra;
    public AudioSource Mi;
    public AudioSource Fa;
    public AudioSource So;
    public AudioSource La;
    public AudioSource Ti;
    public AudioSource Do2;

    public AudioClip Do1;
    public AudioClip Ra1;
    public AudioClip Mi1;
    public AudioClip Fa1;
    public AudioClip So1;
    public AudioClip La1;
    public AudioClip Ti1;
    public AudioClip DoTwo;


    private void Awake()
    {
        weapon = GetComponent<Collider>();
        needle = GetComponent<Collider>();
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
        //if (needle.CompareTag("Do"))
        //{
        //    Do.clip = Do1;
        //    Do.Play();
        //    Debug.Log("Collided with Do.");
        //}
        //if (needle.CompareTag("Ra"))
        //{
        //    Ra.clip = Ra1;
        //    Ra.Play();
        //}
        //if (other.CompareTag("Mi"))
        //{
        //    Mi.clip = Mi1;
        //    Mi.Play();
        //}
        //if (other.CompareTag("Fa"))
        //{
        //    Fa.clip = Fa1;
        //    Fa.Play();
        //}
        //if (other.CompareTag("So"))
        //{
        //    So.clip = So1;
        //    So.Play();
        //}
        //if (other.CompareTag("La"))
        //{
        //    La.clip = La1;
        //    La.Play();
        //}
        //if (other.CompareTag("Ti"))
        //{
        //    Ti.clip = Ti1;
        //    Ti.Play();
        //}
        //if (other.CompareTag("Do2"))
        //{
        //    Do2.clip = DoTwo;
        //    Do2.Play();
        //}
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
