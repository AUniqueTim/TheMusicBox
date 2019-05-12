using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 3;
    [Space]
    [SerializeField] float speed = 3f;
    [Space]
    [SerializeField] Transform waypoint = null;

    [SerializeField] private float timer = 0.5f; //normally 1.5f
    private float currentTimer = 0;


   // private LookAtLockOn lookAtLockOn;
   // public LookAtLockOn lookAtLockOn;

    private int currentWaypoint = 0;
    [SerializeField] private bool playerInRange = false;
    // private Transform player = null;
    public Transform player;
    //audio
    public AudioClip death;
    public AudioSource audiosource;
    public AudioClip Running;
    public AudioSource audiosource2;
    public AudioClip hit;
    public AudioSource audiosource3;

    private void Awake()
    {
      //  lookAtLockOn = FindObjectOfType<LookAtLockOn>();
     //   player = GameObject.FindWithTag("Player").transform;
        if (waypoint != null)
        {
            currentWaypoint = Random.Range(0, waypoint.childCount);
        }

        currentTimer = timer;
    }

    void Update()
    {
        IsAlive();
        if (waypoint != null)
        {
            Patrol();
        }
    }

    void IsAlive()
    {
        if (health <= 0)
        {
         //   if (death != null && audiosource3 != null && audiosource != null)
          //  {
                //death audio
                audiosource3.Stop();
                audiosource.clip = death;
                audiosource.Play();
          //  }

            Destroy(gameObject);
        }
    }

 //   private void OnDestroy()
 //   {
  //      lookAtLockOn.ResetTargets();
  //  }

    public void IsHit()
    {
        if (hit != null && audiosource3 != null)
        {
            //sound for is hit
            audiosource3.clip = hit;
            audiosource3.Play();
        }

        health -= 1;
        print("MICKY IS HURT!");
    }

    void Patrol()
    {
        if (Vector3.Distance(transform.position, player.position) < 5f)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
        LookAtTarget();
        MoveToTarget();

    }

    void LookAtTarget()
    {
        if (!playerInRange)
        {
            transform.LookAt(waypoint.GetChild(currentWaypoint));
        }
        else
        {
            transform.LookAt(player);
        }
    }

    void MoveToTarget()
    {
        if (!playerInRange)
        {
            //running sound
          //  audiosource2.clip = Running;
           // audiosource2.Play();

            if (Vector3.Distance(waypoint.GetChild(currentWaypoint).position, transform.position) < 2f)
            {
                GetNewPosition();
            }
            else
            {
                transform.Translate((waypoint.GetChild(currentWaypoint).position - transform.position).normalized * speed * Time.deltaTime, Space.World);
            }
        }
        else
        {
            if (Vector3.Distance(player.position, transform.position) < 2f)
            {
                currentTimer -= Time.deltaTime;
                if (currentTimer < 0)
                {
                    player.GetComponent<CharacterMovement>().StartGetHit();
                    currentTimer = timer;
                }
            }
            else
            {
                //currentTimer = timer;
                //rat runnning audio?
              
                transform.Translate((player.position - transform.position).normalized * speed * Time.deltaTime, Space.World);
            }
        }
    }

    void GetNewPosition()
    { 
        //rat running audio?

        if (currentWaypoint < waypoint.childCount - 1)
        {
            currentWaypoint++;
        }
        else
        {
            currentWaypoint = 0;
        }
    }
}
