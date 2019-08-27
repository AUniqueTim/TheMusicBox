using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecttoCursor : MonoBehaviour
{
    //public float depth = 10.0f;
    //public Transform myTransform;
    //public Vector3 myVector3;
    public GameObject cursorObject;
    public float distance  = 10f;

    void Start()

    {
        Cursor.visible = false;
    }

    void Update()
    {
        ObjectFollowCursor();
        //var mousePos = Input.mousePosition;
        //var wantedPos = Camera.main.ScreenToWorldPoint(Vector3(mousePos.x, mousePos.y, depth));
        //transform.position = wantedPos;
    }
    void ObjectFollowCursor()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 point = ray.origin + (ray.direction * distance);
        Debug.Log( "World point " + point );

        cursorObject.transform.position = point;
    }
}
