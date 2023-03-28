using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;// initilize speed, can change from unity
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    GetComponent<Transform>().Rotate(0,0,speed*Time.deltaTime);  // using the Rotate method, make object rotate by changeing the 'z values 
    
    }
}
