using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Web;
using UnityEngine;

public class camsnap : MonoBehaviour
{
    public Transform cam;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.RotateAround(transform.position, transform.up, 180f);
        }
    }
}
