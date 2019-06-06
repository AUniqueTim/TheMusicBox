using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshCollider))]
public class MusicNoteDragandDrop : MonoBehaviour
{
    public Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDrag()
    {
        //Pickup/highlight note object being dragged.
    }
}

    

