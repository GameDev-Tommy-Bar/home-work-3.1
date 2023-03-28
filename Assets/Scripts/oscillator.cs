using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float max_lim = 5; // initilized oscillator limits, can changed from the unity gui
    [SerializeField]
    float speed = 0.1f; // initilized speed, can changed from the unity gui
    float sin; // store the sin func results
    Vector3 curr; // store the current object pos
    void Start()
    {
        curr = GetComponent<Transform>().position; // assign the origin spot
    }

    // Update is called once per frame
    void Update()
    {
        sin = max_lim *Mathf.Sin(Time.time * speed); // the sinus func will go from 1 to -1. when multiply by max_lim, the distance become |max lim| for both positive and negtive x sides
        GetComponent<Transform>().position = new Vector3(curr.x + sin , curr.y ,curr.z); // update the current x position for moving the oscillator.
    }
}
