using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSoundTestScript : MonoBehaviour
{
    public AudioClip startSound;
    public AudioSource audiosource2;
    private float timer = -1f;


    public void StartAudio()
    {
        audiosource2.clip = startSound;
        audiosource2.Play();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            //Debug.Log("timer is at zero");
            audiosource2.Stop();
            //audiosource2.enabled = false;
            //audiosource2.loop = false;
        }
    }

    public void SetTimer(float seconds)
    {
        timer = seconds;
    }
}
