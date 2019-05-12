using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //DONT FORGET THISSSS

public class AudioAndStuff : MonoBehaviour
{
    //audio stuff for doors
    public AudioClip door1;
    public AudioClip door2;
    public AudioClip door3;
    public AudioSource audiosource1;

    public GameObject musicboxUI;

    //audio stuff for puzzle pieces
    public AudioClip piece1;
   // public AudioClip piece2;
   // public AudioClip piece3;
   // public AudioClip piece4;
    public AudioSource audiosource2;

    //audio stuff for health
    public AudioClip hurt;
    public AudioSource audiosource3;
    public AudioClip death;
    public AudioSource audiosource4;
    public AudioClip winSound;
    public AudioSource audiosource5;

    //animation stuff
    private Animator animator1;
    private Animator animator12;
    private Animator animator2;
    private Animator animator22;
    private Animator animator3;
    public GameObject door_1;
    private GameObject door_12;
    private GameObject door_2;
    private GameObject door_22;
    private GameObject door_3;

    public Animator myAnimator;

    //collider stuff
    private BoxCollider boxcollider1;
    private BoxCollider boxcollider12;
    private BoxCollider boxcollider2;
    private BoxCollider boxcollider22;
    private BoxCollider boxcollider3;

    //UI stuff
    //private GameObject musicBox;
    //Text pieces;
    //private int piecesAmount;

    //cool-down
    float timeLeft = 0.9f;
  //  float timer = 5f;

    void Start()
    {
        //try public drag and drop for these
       // door_1 = GameObject.Find("Ancient_Gate_Model");
        animator1 = door_1.GetComponent<Animator>(); ///cannot find object????????????????????
        boxcollider1 = door_1.GetComponent<BoxCollider>();

        door_12 = GameObject.Find("Locked_Door_1");
        animator12 = door_12.GetComponent<Animator>();
        boxcollider12 = door_12.GetComponent<BoxCollider>();

        door_2 = GameObject.Find("Locked_Door_2");
        animator2 = door_2.GetComponent<Animator>();
        boxcollider2 = door_2.GetComponent<BoxCollider>();

        door_22 = GameObject.Find("Locked_Door_22");
        animator22 = door_22.GetComponent<Animator>();
        boxcollider22 = door_22.GetComponent<BoxCollider>();

        door_3 = GameObject.Find("Locked_Door_3");
        animator3 = door_3.GetComponent<Animator>();
        boxcollider3 = door_3.GetComponent<BoxCollider>();

        // musicBox = GameObject.Find("PiecesAmount");
        //pieces = musicBox.GetComponent<Text>();
        // piecesAmount = 0;

    }


        
    

    void Update()
    {
        if (Tester.health <= 0)
        {
            timeLeft = timeLeft - Time.deltaTime;

            if (timeLeft <= 0.0f)
            // if(myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Idle") == true)
            {
                audiosource4.Stop();
            }
        }
        // pieces.text = piecesAmount.ToString(); //turn piecesamount to a string and put it in the musicBox text component
    }

    public void CheckHealth()
    {
            //  Debug.Log("Collided with enemy");
            //Health.health = Health.health - 1;
            if (Tester.health > 0)
            {
               // Debug.Log("Should get hurt sound");
                audiosource3.clip = hurt;
                audiosource3.Play();
            myAnimator.SetInteger("Death", 1);
        }
            if (Tester.health <= 0)
            {
               // Debug.Log("Should die sound");
                audiosource4.clip = death;
                audiosource4.Play();
            //DEATH ANIMATION!!!!!!!!!!!!!!
               myAnimator.SetInteger("Death", 0);

            //   if(myAnimator.GetCurrentAnimatorStateInfo(0).IsName("Falling_Forward_Death") == true)
            //    {

            //    myAnimator.SetBool("ExitDeath", true);
            //  }

            GameMenus.gameover = true; //want the game over menu to pop-up

            if (GameMenus.quit == true)
            {
                audiosource4.Stop();
            }
                
            }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
        }

        //if player collides with any puzzle piece
        if (other.gameObject.tag == "Item")
        {
          //  timeLeft = timeLeft - Time.deltaTime;
            //may have to create a diff tag for each puzzle piece
            Destroy(other.gameObject);

            //dont want to collect piece more often than every 0.3 seconds
            //DONT THINK I DID THIS TIMER RIGHT SINCE ITS ONTRIGGERENTER??!!!!!
          //  if (timeLeft <= 0.0f)
         //   {
           //     PiecesCounter.piecesAmount = PiecesCounter.piecesAmount + 1;
                audiosource2.clip = piece1;
                audiosource2.Play();
            //    timeLeft = 0.3f;
           // }
        }

        //if player collide with certain key, destroy key object, open door animation, play opendoor sound of certain door
        if (other.gameObject.tag == "Key1")
        {
            PickUpPopUp.Opened2doors = true; //opened two doors pop-up
            Destroy(other.gameObject);
            animator1.SetBool("Open", true); //open door animation for door1
            Destroy(boxcollider1); //destroy box collider on this door
            animator12.SetBool("Open", true); //open door animation for door12
            Destroy(boxcollider12); //destroy box collider on this door
            audiosource1.clip = door1;
            audiosource1.Play();
        }
        if (other.gameObject.tag == "Key2") //check if works!!!!!!!!!!!!!!!!!
        {
            PickUpPopUp.Opened2doors = true; //opened two doors pop-up
            Destroy(other.gameObject);
            animator2.SetBool("Open", true); //open door animation for door2
            Destroy(boxcollider2); //destroy box collider on this door
            animator22.SetBool("Open", true); //open door animation for door22
            Destroy(boxcollider22); //destroy box collider on this door
            audiosource1.clip = door2;
            audiosource1.Play();
        }
        if (other.gameObject.tag == "Key3")// && PickUpPopUp.DroppedBallerina == true && PickUpPopUp.DroppedHorn == true && PickUpPopUp.DroppedHandle == true && PickUpPopUp.DroppedKey == true)//check if works!!!!!!!!!!!!!!!!!!!!!!
        {
            PickUpPopUp.Opened1door = true; //opened one door pop-up
            Destroy(other.gameObject);
            animator3.SetBool("Open", true); //open door animation for door3
            Destroy(boxcollider3); //destroy box collider on this door
            audiosource1.clip = door3;
            audiosource1.Play();
        }
        if (other.gameObject.name == "WinTrigger") //check if worksss!!!!!!!!!!!!
        {
           // timer = timer - Time.deltaTime;
            //want this so the player knows they won
            GameMenus.win = true;
            audiosource5.clip = winSound;
            audiosource5.Play();
          //  if (timer <= 0.0f)
          //  { 
                //want win screen off canvas
            //    GameMenus.win = false;
                //high level ending
             //   Ending.end = true;
            //}
        }

        }
}
