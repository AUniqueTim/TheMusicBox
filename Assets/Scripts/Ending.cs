using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Dont forget!!!!!!!!!!!!

public class Ending : MonoBehaviour
{
    public GameObject EndingUI;
    public GameObject IntroUI;

    public static bool end = false;

    //audio
    public AudioClip MusicBoxSound;
    public AudioSource audiosource;

    //freezing player and camera
    public  GameObject player;
    //  private GameObject camera;
    private CharacterMovement move;
    //  private MouseRotation mouse;
    // private MouseRotation mouseY;

    void Start()
    {
       // if (GameObject.Find("Player") != null)
      //  {
           // player = GameObject.Find("Player");
            //  camera = GameObject.Find("FollowPlayer");
            move = player.GetComponent<CharacterMovement>();
            //   mouse = player.GetComponent<MouseRotation>();
            //  mouseY = camera.GetComponent<MouseRotation>();
      //  }
    }

    void Update()
    {
        if (end == true)
        {
            EndingUI.SetActive(true);
            //freeze character
            move.enabled = false;
            //  mouse.enabled = false;
            // mouseY.enabled = false;
            //audio
            audiosource.clip = MusicBoxSound;
            audiosource.Play();
            player.SetActive(false);
            //adjust volume!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Time.timeScale = 0f;
        }
    }
    //quit button
    public void Quit()
    {
        //NEED TO TEST THIS!!!!!!!!!!
        Application.Quit();
    }

    //restart button
    public void Restart() //TESTTTTT!!!!!!!!!!!!
    {
        end = false;
        EndingUI.SetActive(false);
        IntroUI.SetActive(true);
        player.SetActive(true);
        //Intro UI is true
        //NEED TO ADD THIS SCENE TO BUILD SETTINGS!!!!!!!!!
        SceneManager.LoadScene("Tutorial_Puzzle_Final");
    }
}
