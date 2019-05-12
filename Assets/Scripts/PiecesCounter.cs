using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //DONT FORGET THISSSS

public class PiecesCounter : MonoBehaviour
{
    Text pieces;
    public static int piecesAmount;

    void Start()
    {
        pieces = GetComponent<Text>();
    }

    void Update()
    {
        
        pieces.text = piecesAmount.ToString();
        

    }
}
