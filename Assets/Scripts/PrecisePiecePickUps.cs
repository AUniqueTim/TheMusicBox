using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrecisePiecePickUps : MonoBehaviour
{
    private void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //If we collide with the spot where we place them, disable them on UI!!!!!!!!!!!!!!!!!!!!!!!!
        if (other.gameObject.name == "Horn")
        {
            Destroy(other);
            //Adds icon to the UI
            PickUpPopUp.GotHorn = true;
        }
        if (other.gameObject.name == "Ballerina2")
        {
            Destroy(other);
            //Adds icon to the UI
            PickUpPopUp.GotBallerina = true;
        }
        if (other.gameObject.name == "Music_Box_Key")
        {
            Destroy(other);
            //Adds icon to the UI
            PickUpPopUp.GotKey = true;
        }
        if (other.gameObject.name == "Handle")
        {
            Destroy(other);
            //Adds icon to the UI
            PickUpPopUp.GotHandle = true;
        }
    }
}
