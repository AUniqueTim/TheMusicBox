using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPuzzle : MonoBehaviour
{
    //BASIC VARIABLES
    
    //Music Note Objects

    public GameObject Do;
    public GameObject Re;
    public GameObject Mi;
    public GameObject Fa;
    public GameObject Sol;
    public GameObject La;
    public GameObject Ti;
    public GameObject Do2;

    public GameObject boxKey;
    public GameObject boxHorn;
    public GameObject boxHandle;
    public GameObject boxBallerina;

    //Position of Notes

    private Vector3 doPos;
    private Vector3 rePos;
    private Vector3 miPos;
    private Vector3 faPos;
    private Vector3 solPos;
    private Vector3 laPos;
    private Vector3 tiPos;
    private Vector3 do2Pos;

    //Puzzle Success Boolean

    private bool puzSuccess;
    private bool partsPresent;
    private bool posCorrect;

                            //public var PuzzlePiece;  //Variable? to put on the missing pieces
                            //public var CombSensor; //square blocks under the comb that will either eject (line23) or accept (line25) the missing pieces 
                            //public var CorrectPosition; //to check if all 3 puzzle pieces are in the right place



    void Start()
    {
        if (puzSuccess == true)
        {

            //Button pop up to grow in size/ transistion to main_level scene?
        }

    }
    void Update()
    {
        //BASIC STATEMENTS

        //Check if Music Box parts/puzzle pieces are present in scene.

        if (partsPresent == true)
        {
            print("All Music Box parts found!");
        }

        if (partsPresent == false)
        {
            print("You have not yet found all the music box parts!");

        }

        //also have to implement how to put down/pick up objects and how the player will interact with the puzzle scene. simple mouse click and abandon the avatar on the puzzle view?
        //OnMouseDrag()?
    }
}
