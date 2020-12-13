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
    bool wave;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        increasing = true;
        wave = Random.value > 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        angle += 2;
        if (wave)
        {
            if (increasing)
            {
                x += 0.01f;
                y += (Mathf.Sin((float)0.01 * angle) / 60);
                myTransform.position = new Vector3(x, y, z);
                if (x >= max)
                {
                    increasing = !increasing;
                }
            }
            else
            {
                x -= 0.02f;
                y += Mathf.Sin((float)0.01 * angle) / 50;
                if (y > 5)
                {
                    y = 5;
                }
                myTransform.position = new Vector3(x, y, z);
                if (x <= min)
                {
                    increasing = !increasing;
                }
            }
        }
        else
        {
            if (increasing)
            {
                x += 0.01f;
                myTransform.position = new Vector3(x, y, z);
                if (x >= max)
                {
                    increasing = !increasing;
                }
            }
            else
            {
                x -= 0.02f;
                if (y > 5)
                {
                    y = 5;
                }
                myTransform.position = new Vector3(x, y, z);
                if (x <= min)
                {
                    increasing = !increasing;
                }
            }
        }

    }
}
