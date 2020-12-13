using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacteria : MonoBehaviour
{ 
    float min = -5;
    float max = (float)5.75;
    float x;
    float y; 
    float z;
    float angle = 0;
    bool increasing;
    public Transform myTransform;

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        increasing = true;
    }

    // Update is called once per frame
    void Update()
    {   
        angle += 2;
        if(increasing)
        {
            x += 0.02f;
            y += Mathf.Sin((float)0.01*angle)/50;
            myTransform.position = new Vector3(x, y, z);
            if(x >= max)
            {
                increasing = !increasing;
            }
        }
        else
        {
            x -= 0.02f;
            y += Mathf.Sin((float)0.01*angle)/50;
            myTransform.position = new Vector3(x, y, z);
            if(x <= min)
            {
                increasing = !increasing;
            }
        }
    }
}
