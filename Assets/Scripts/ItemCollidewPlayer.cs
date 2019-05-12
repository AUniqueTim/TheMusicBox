using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollidewPlayer : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            PiecesCounter.piecesAmount = PiecesCounter.piecesAmount + 1;
        }
    }
}
