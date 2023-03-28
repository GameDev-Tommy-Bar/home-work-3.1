using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
{
    bool turn = true; // decide if the item needs to grow - true, or become smaller - false.
    Vector3 scaleChange; // vector the will determent the scale change of the object in each frame
    float max_size;
    // Start is called before the first frame update

    void Start()
    {
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        max_size = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if(turn == true){ // needs to grow
            gameObject.transform.localScale += scaleChange; // local sacle increased
        }
        else{
            gameObject.transform.localScale -= scaleChange;// local scale decreased
        }
        if(gameObject.transform.localScale.x >= max_size){ // if the object touched the max size now need to become smaller - false
            turn = false;
        }
        if(gameObject.transform.localScale.x <= 1){ // touched the lower limit, need to grow - true
            turn = true;
        }
        
}}

