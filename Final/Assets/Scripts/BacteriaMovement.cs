using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaMovement : MonoBehaviour
{
    float xPos;
    float yPos;
    bool increasing;
    public float max;
    public float min;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(xPos < max)
        {
            increasing = true; 
        }
    }
}
