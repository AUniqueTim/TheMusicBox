using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class GameMenus : MonoBehaviour
{

    public static bool gameover = false;
    public static bool pause = false;
    public static bool win = false;
    public bool PressedBack = false;

 //   public static bool dropHorn = false;
   // public static bool dropKey = false;
   // public static bool dropBallerina = false;
  //  public static bool dropHandle = false;

    public GameObject GameOverUI;
    public GameObject PauseUI;
    public GameObject WinUI;
    public GameObject AimerUI;
    public GameObject ControlsUI;
    public GameObject IntroUI;
    public GameObject boxUI;
    public GameObject mainlevelUI;
//    public GameObject BoxSceneStuff;
 //   public GameObject TutorialSceneStuff;

    //freezing player and camera
    public GameObject player;
    private GameObject camera;
    private CharacterMovement move;
    private MouseRotation mouse;
    private MouseRotation mouseY;

    //audio
    public AudioClip WinSound;
    public AudioSource audiosource;

  //  public Transform TargetPlayerLocation;
  //  public Transform TargetPlayerLocation2;

 //   public GameObject TargetPlayerLocation;
  //  public GameObject TargetPlayerLocation2;


    //audio
    //  public AudioClip success;
    //  public AudioSource audiosource1;

    public static bool quit = false;

    private float timer = 3f;

    void Start()
    {
      //  if (GameObject.Find("Player") != null)
       // {
          //  player = GameObject.Find("Player");
          //  camera = GameObject.Find("FollowPlayer");
            move = player.GetComponent<CharacterMovement>();
          //  mouse = player.GetComponent<MouseRotation>();
          //  mouseY = camera.GetComponent<MouseRotation>();
          //  move.enabled = false;

      //  }
        //AimerUI.SetActive(true);
      //  Manager.Instance.TransitionTarget2.position = TargetPlayerLocation2.transform.position;
     //   Manager.Instance.TransitionTarget.position = TargetPlayerLocation.transform.position;

    }

    void Update()
    {
        //  BoxSceneStuff = GameObject.FindWithTag("box");
        //  TutorialSceneStuff = GameObject.FindWithTag("puzzle");

        //in case the UI object was still active in puzzle scene
        //if (IntroUI != null && IntroUI.activeInHierarchy == true && Introduction.start == false)
        //{
        //  //  IntroUI.SetActive(false);
        //    move.enabled = false;
        //}

        if (IntroUI != null && IntroUI.activeInHierarchy == true && Introduction.start == true)
        {
            IntroUI.SetActive(false);
            move.enabled = true;
        }
        //remove or add aimer
        if (gameover == true || win == true)
        {
            AimerUI.SetActive(false);
        }

        if (gameover == true) //just if
        {
            //enable the game over object with restart and quit buttons
            GameOverUI.SetActive(true);

        } else if (gameover == false)
        {
            GameOverUI.SetActive(false);
        }

       if (win == true) //TESTTT!!!!!!!!!!!!!!!! //just if
        {
            timer = timer - Time.deltaTime;
            WinUI.SetActive(true);
            if (timer <= 0.0f)
            {
                Ending.end = true;
                WinUI.SetActive(false);
            }
            //  audiosource.clip = WinSound;
            // audiosource.Play();
            //Character Dancing????????!!!!!!!!!!!!

        }
        else if (win == false)
        {
            WinUI.SetActive(false);
            //stop dancing???????????!!!!!!!!!!!!!
        }

        if (Input.GetKeyDown(KeyCode.Escape) || PressedBack == true) //just if
        {
            AimerUI.SetActive(false);
            

            if (pause == true)
            {
                Resume();
            }
            else
            {
                Pause();
                PressedBack = false;
            }
        } 
    }

    //resume button
    public void Resume()
    {
        PauseUI.SetActive(false);
        if (boxUI != null)
        {
            boxUI.SetActive(false);
        }
        AimerUI.SetActive(false);
        if (mainlevelUI != null)
        {
            mainlevelUI.SetActive(false);
        }
        // Time.timeScale = 1f;
        pause = false;
        //re-enable character scripts
        move.enabled = true;
        mouse.enabled = true;
        mouseY.enabled = true;
    }

  //  public void DropHorn()
  //  {
    //    dropHorn = true;
      //  audiosource1.clip = success;
     //   audiosource1.Play();
 //   }
  //  public void DropBallerina()
  //  {
     //   dropBallerina = true;
      //  audiosource1.clip = success;
       // audiosource1.Play();
  //  }
   // public void DropKey()
   // {
   //     dropKey = true;
  //  }
  //  public void DropHandle()
  //  {
    //    dropHandle = true;
  //  }

    public void Pause()
    {
        PauseUI.SetActive(true);
      
        //freeze game
        //Time.timeScale = 0f;
        pause = true;
        //freeze character
        move.enabled = false;
        mouse.enabled = false;
        mouseY.enabled = false;
        //PAUSE MUSIC!!!!!!!!!!!!!!!
    }

    public void Controls()
    {
        ControlsUI.SetActive(true);
        PauseUI.SetActive(false);

        //freeze game
      //  Time.timeScale = 0f;
        //freeze character
        move.enabled = false;
        mouse.enabled = false;
        mouseY.enabled = false;
    }

    public void Back()
    {
        ControlsUI.SetActive(false);
        PauseUI.SetActive(true);
        PressedBack = true;
        pause = true;
    }

    //restart button
    public void Restart()
    {
       // Debug.Log("pressed restart");
        //NEED TO ADD THIS SCENE TO BUILD SETTINGS!!!!!!!!!
        // SceneManager.LoadScene("Tutorial_Puzzle");
        SceneManager.LoadScene("Tutorial_Puzzle_Final");
        GameOverUI.SetActive(false);
        PauseUI.SetActive(false);
        ControlsUI.SetActive(false);
        WinUI.SetActive(false);

        IntroUI.SetActive(true);
        Time.timeScale = 1f; //make sure that not paused
        //RESET HEALTH AND INVENTORY
      //  PlayerPrefs.DeleteKey("health");
    }

    public void StartMainLevel()
    {
        //  BoxSceneStuff.SetActive(true);
        //  SceneManager.UnloadSceneAsync("LevelScene 1");
        //  SceneManager.LoadScene("LevelScene 2", LoadSceneMode.Additive);
        //  SceneManager.UnloadSceneAsync("Tutorial_Puzzle_Copy_For_Testing");

        // move from dont destroy to scene
        

        mainlevelUI.SetActive(false);
        SceneManager.LoadScene("Main_Level_Final");
    //    SceneManager.MoveGameObjectToScene(BoxSceneStuff, SceneManager.GetActiveScene());
        //  DontDestroyOnLoad(TutorialSceneStuff);
        //  BoxSceneStuff.SetActive(true);
        //   TutorialSceneStuff.SetActive(false);

        //   SceneManager.LoadScene("Main_Level_Copy_For_Testing", LoadSceneMode.Additive);

        //REMOVE PUZZLE SCENE TRANSITION POPUP
        //    if (mainlevelUI != null)
        //  {
        //   mainlevelUI.SetActive(false);
        // }
    }


    //   public void StartMainLevel2()
    //  {
    //NEED TO ADD THIS SCENE TO BUILD SETTINGS!!!!!!!!!
    // SceneManager.LoadScene("Main_Level");

    // }
    public void GoInside()
    {
        // BoxSceneStuff.SetActive(false);
        //  SceneManager.UnloadSceneAsync("LevelScene 1");
        //  SceneManager.LoadScene("LevelScene 2", LoadSceneMode.Additive);
        // SceneManager.UnloadSceneAsync("Main_Level_Copy_For_Testing");

        // DontDestroyOnLoad(BoxSceneStuff);
        //  BoxSceneStuff.SetActive(false);
        //   TutorialSceneStuff.SetActive(true);
        //   SceneManager.LoadScene("Tutorial_Puzzle_Copy_For_Testing", LoadSceneMode.Additive);
        //Assign the transition target location.

        //move from dontdestroy to scene
        

        IntroUI.SetActive(false);
        SceneManager.LoadScene("Tutorial_Puzzle_Final");
       // SceneManager.MoveGameObjectToScene(TutorialSceneStuff, SceneManager.GetActiveScene());


    }

    //quit button
    public void Quit()
    {
        quit = true;
      //  PlayerPrefs.DeleteKey("health");
        Application.Quit();
    }

}
