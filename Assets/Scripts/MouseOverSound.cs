using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverSound : MonoBehaviour
{
    [SerializeField] private AudioClip sound = null;
    [SerializeField] private AudioSource audioSource;

    private void OnMouseEnter()
    {

            print("play song" + gameObject.name);
        if (audioSource != null && sound != null)
        {
            audioSource.clip = sound;
            audioSource.Play();
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
