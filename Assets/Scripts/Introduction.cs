using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public static bool start = false;

    public GameObject IntroUI;
    public GameObject InventoryUI;
    public GameObject TutorialUI;
    public GameObject HealthUI;
    public Camera maincamera;

    //audio
    public AudioClip music;
    public AudioSource audiosource1;
    public AudioClip startSound;
    public AudioSource audiosource2;

    //freezing player and camera
    public GameObject player;
   // private GameObject camera;
    private CharacterMovement move;
    //  private MouseRotation mouse;
    //  private MouseRotation mouseY;
    // public Animator animator;
    private float timer = 4f;
    //animation stuff
    private Animator animator;

    void Awake()
    {
      //  player = GameObject.Find("Player"); //?????????????????????????????
        ////  camera = GameObject.Find("FollowPlayer");
        move = player.GetComponent<CharacterMovement>(); //????????????????????????
        ////   mouse = player.GetComponent<MouseRotation>();
        ////   mouseY = camera.GetComponent<MouseRotation>();
        animator = IntroUI.GetComponent<Animator>(); //???????????????????????????????
        //  player.SetActive(false);
        // animator.SetBool("Fade", false);
        if (maincamera != null)
        {
            maincamera.enabled = true;
        }
        //fix volume
        audiosource1.volume = 0.3f; //0.1f;
        audiosource1.loop = true;
        audiosource1.pitch = 0.5f;
        //for starting game sound
        audiosource2.clip = startSound;
        InventoryUI.SetActive(false);
        HealthUI.SetActive(false);

        move.enabled = false;
        player.SetActive(false);

    }

    void Start()
    {
        //   InventoryUI.SetActive(false);
        if (audiosource1 != null)
        {
            audiosource1.clip = music;
            //start playing music right away
            audiosource1.Play();
        }

    }

    void Update()
    {
        //if were starting the game without the intro scene
        if (IntroUI.activeInHierarchy == false)
        {
            InventoryUI.SetActive(true);
            HealthUI.SetActive(true);
            audiosource1.Stop();
           // InventoryUI.SetActive(true);
          //  HealthUI.SetActive(true);
            move.enabled = true;
            start = true;
            player.SetActive(true);
        }
    //    else
      //  {
            
      //  }
        //   TutorialUI.SetActive(true);
        //  Debug.Log("IntroUI is not active, also stopping sound");
        //  }

        //In Intro menu
        if (start == false)
        {
           // Time.timeScale = 0f;
            //freeze character
            move.enabled = false; //????????????????????????????
         //   mouse.enabled = false;
          //  mouseY.enabled = false;
        }
        if(start == true)
        {
            if (maincamera != null)
            {
                maincamera.enabled = false;
            }
            timer = timer - Time.deltaTime;
           move.enabled = true; //???????????????????????????????????????
            animator.enabled = true;
            animator.SetBool("Fade", true);

            if (timer <= 0)
            {
              //  Debug.Log("timer is at zero");
               IntroUI.SetActive(false); //????????????!!!!!!!!!!!!!
                audiosource2.Stop();
                animator.enabled = false;
            //    if (TutorialUI != null)
             //   {
              //      TutorialUI.SetActive(true);
                }
                //   animator.
            
        }
    }

    //start button
    public void StartGame()
    {
        //Introduction.start = true;
        start = true;
        //disabe music and enable start sound
        audiosource1.Stop();
        //REMOVE SOUND IF NO FADE OUT ANIMATION!!!!!!!!!!!!
        // audiosource2.Play();
        //move.enabled = true;
        if (maincamera != null)
        {
            maincamera.enabled = false;
        }
        //   Time.timeScale = 1f;
        //FADE OUT ANIMATION???????!!!!!!!!!!!!!!!
        animator.Play("IntroFadeOut");
        animator.SetBool("Fade", true);
        player.SetActive(true);
        // animator.Play("IntroFadeOut");
       // animator.
        //   IntroUI.SetActive(false);
        // animator.SetBool("DoneFade", true);

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("IntroFadeOut") == false){
          //  IntroUI.SetActive(false); //????????????!!!!!!!!!!!!!
             InventoryUI.SetActive(true);
         //   player.SetActive(true);
            //re-enable character scripts
          //   move.enabled = true;
            audiosource2.Stop();
          //  TutorialUI.SetActive(true);
            // animator.enabled = false;
            //  mouse.enabled = true;
            //  mouseY.enabled = true;
            //  Debug.Log("Went into exit of anim");
        }

        //lower volume of audiosource2?????????????


    }

    //quit button
    public void Quit()
    {
        //NEED TO TEST THIS!!!!!!!!!!
        Application.Quit();
    }
}
