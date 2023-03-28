using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()   
    {
        if (Input.GetMouseButtonDown(0)){ // trigger the mouse left click, when clicked the value turns true
            if(gameObject.GetComponent<SpriteRenderer>().isVisible == true){ // checks if the object is visible or invisible
                gameObject.GetComponent<SpriteRenderer>().enabled = false; // object visible, lets hide it
            }
            else {
                gameObject.GetComponent<SpriteRenderer>().enabled = true; // object invisible, lets unhide it
            }
    }
    }
}



