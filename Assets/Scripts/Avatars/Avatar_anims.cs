using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_anims : MonoBehaviour
{

    //VARIABLES

    Animator anim;
    //int runStateWalk = Animator.StringToHash("Base Layer.Walking");
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float idle = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", idle);

       AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);

        if (Input.GetKeyDown(KeyCode.W)) //&& stateInfo.fullPathHash == runStateWalk)
        {

            //float walk = Input.GetAxis("Horizontal");
            anim.SetTrigger("Walking");

        }
    }
}
