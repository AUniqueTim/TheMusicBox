using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDrop : MonoBehaviour
{
    public static bool dropHorn = false;
    public static bool dropKey = false;
    public static bool dropBallerina = false;
    public static bool dropHandle = false;

    public GameObject musicboxUI;
    public GameObject goMain;

    //audio
    public AudioClip success;
    public AudioSource audiosource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "musicbox") //check if worksss!!!!!!!!!!!!
        {
            if (musicboxUI != null)
            {
                musicboxUI.SetActive(true);
            }
        }

        if (other.gameObject.name == "RedTrigger" && PickUpPopUp.GotBallerina == true)
        {
            //drop piece
            Destroy(other.gameObject);
            Debug.Log("RedBox should be destroyed");
            dropBallerina = true;
            //play success audio
            audiosource.clip = success;
            audiosource.Play();
        }
        if (other.gameObject.name == "YellowTrigger" && PickUpPopUp.GotKey == true)
        {
            //drop piece
            Destroy(other.gameObject);
            Debug.Log("YellowBox should be destroyed");
            dropKey = true;
            //play success audio
            audiosource.clip = success;
            audiosource.Play();
        }
        if (other.gameObject.name == "GreenTrigger" && PickUpPopUp.GotHandle == true)
        {
            //drop piece
            Debug.Log("GreenBox should be destroyed");
            Destroy(other.gameObject);
            dropHandle = true;
            //play success audio
            audiosource.clip = success;
            audiosource.Play();
        }
        if (other.gameObject.name == "BlueTrigger" && PickUpPopUp.GotHorn == true)
        {
            //drop piece
            Debug.Log("BlueBox should be destroyed");
            Destroy(other.gameObject);
            dropHorn = true;
            //play success audio
            audiosource.clip = success;
            audiosource.Play();
        }
        if (other.gameObject.name == "GoBackToMain")
        {
            if (goMain != null)
            {
                goMain.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
