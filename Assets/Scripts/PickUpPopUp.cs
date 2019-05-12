using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPopUp : MonoBehaviour
{
    public static bool Opened2doors = false;
    public static bool Opened1door = false;

    public static bool GotBallerina = false;
    public static bool GotHandle = false;
    public static bool GotHorn = false;
    public static bool GotKey = false;

    public static bool DroppedBallerina = false;
    public static bool DroppedHandle = false;
    public static bool DroppedHorn = false;
    public static bool DroppedKey = false;

    public bool BallerinaPopUpGone = false;
    public bool HandlePopUpGone = false;
    public bool HornPopUpGone = false;
    public bool KeyPopUpGone = false;

    public GameObject TwoDoorsUI;
    public GameObject OneDoorUI;

    public GameObject BallerinaUI;
    public GameObject HandleUI;
    public GameObject HornUI;
    public GameObject KeyUI;

    public GameObject BallerinaIconUI;
    public GameObject HandleIconUI;
    public GameObject HornIconUI;
    public GameObject KeyIconUI;

    float timeLeft = 3.0f;
    float timeLeft2 = 3.0f;
    float timeLeft7 = 3.0f;

    float timeLeft3 = 5.0f;
    float timeLeft4 = 5.0f;
    float timeLeft5 = 5.0f;
    float timeLeft6 = 5.0f;
    //make another timer for puzzle piece text?? 5 or 4 sec?

    //audio
    public AudioClip success;
    public AudioSource audiosource;

    private void Awake()
    {
        audiosource.enabled = true;
    }

    void Update()
    {
        if (Opened2doors == true)
        {
            timeLeft = timeLeft - Time.deltaTime; //want this timer to start only once we have a key
         //   timeLeft7 = timeLeft - Time.deltaTime;

            TwoDoorsUI.SetActive(true);
            //if we have reached the allocated time for this pop-up
            if (timeLeft <= 0.0f || timeLeft7 <= 0.0f)
            {
                TwoDoorsUI.SetActive(false);
                Opened2doors = false;
                 timeLeft = 3.0f;
            }
        }
        if (Opened1door == true)
        {
            timeLeft2 = timeLeft2 - Time.deltaTime; //want this timer to start only once we have a key

            OneDoorUI.SetActive(true);
            //if we have reached the allocated time for this pop-up
            if (timeLeft2 <= 0.0f)
            {
                OneDoorUI.SetActive(false);
                Opened2doors = false;
                //  timeLeft2 = 3.0f;
            }
        }
        if (PieceDrop.dropBallerina == true || PieceDrop.dropKey == true || PieceDrop.dropHorn == true || PieceDrop.dropHandle == true)
        {
            //play success audio
            audiosource.clip = success;
            audiosource.Play();
        }
        if (GotBallerina == true && BallerinaPopUpGone != true)
        {
            BallerinaIconUI.SetActive(true);
            timeLeft3 = timeLeft3 - Time.deltaTime; //want this timer to start only once we have a key
            if (BallerinaUI != null)
            {
                BallerinaUI.SetActive(true);
            }
            //if we have reached the allocated time for this pop-up
            if (timeLeft3 <= 0.0f)
            {
                if (BallerinaUI != null)
                {
                    BallerinaUI.SetActive(false);
                }
                BallerinaPopUpGone = true;
                // timeLeft = 3.0f;
            }
        }
        else if (PieceDrop.dropBallerina == true)
        {
            Debug.Log("we dropped ballerina");
            DroppedBallerina = true;
            BallerinaIconUI.SetActive(false);
          //  BallerinaUI.SetActive(false);
            GotBallerina = false;
            audiosource.clip = success;
            audiosource.Play();
        }

        if (GotHandle == true && HandlePopUpGone != true)
        {
            HandleIconUI.SetActive(true);
            timeLeft4 = timeLeft4 - Time.deltaTime; //want this timer to start only once we have a key
            if (HandleUI != null)
            {
                HandleUI.SetActive(true);
            }
            //if we have reached the allocated time for this pop-up
            if (timeLeft4 <= 0.0f)
            {
                if (HandleUI != null)
                {
                    HandleUI.SetActive(false);
                }
                HandlePopUpGone = true;
               // timeLeft = 3.0f;
            }
        }
        else if (PieceDrop.dropHandle == true)
        {
            Debug.Log("we dropped handle");
            DroppedHandle = true;
            HandleIconUI.SetActive(false);
          //  HandleUI.SetActive(false);
            GotHandle = false;
            audiosource.clip = success;
            audiosource.Play();
        }

        if (GotHorn == true && HornPopUpGone != true)
        {
            HornIconUI.SetActive(true);
            timeLeft5 = timeLeft5 - Time.deltaTime; //want this timer to start only once we have a key
            if (HornUI != null)
            {
                HornUI.SetActive(true);
            }
            //if we have reached the allocated time for this pop-up
            if (timeLeft5 <= 0.0f)
            {
                if (HornUI != null)
                {
                    HornUI.SetActive(false);
                }
                HornPopUpGone = true;
               // timeLeft = 3.0f;
            }
        }
        else if (PieceDrop.dropHorn == true)
        {
            Debug.Log("we dropped horn");
            DroppedHorn = true;
            HornIconUI.SetActive(false);
         //   HornUI.SetActive(false);
            GotHorn = false;
            audiosource.clip = success;
            audiosource.Play();
        }

        if (GotKey == true && KeyPopUpGone != true)
        {
            KeyIconUI.SetActive(true);
            timeLeft6 = timeLeft6 - Time.deltaTime; //want this timer to start only once we have a key
            if (KeyUI != null)
            {
                KeyUI.SetActive(true);
            }
            //if we have reached the allocated time for this pop-up
            if (timeLeft6 <= 0.0f)
            {
                if (KeyUI != null)
                {
                    KeyUI.SetActive(false);
                }
                KeyPopUpGone = true;
                //timeLeft = 3.0f;
            }
        }
        else if (PieceDrop.dropKey == true)
        {
            Debug.Log("we dropped key");
            DroppedKey = true;
            KeyIconUI.SetActive(false);
          //  KeyUI.SetActive(false);
            GotKey = false;
            audiosource.clip = success;
            audiosource.Play();
        }
    }
}
