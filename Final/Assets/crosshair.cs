using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    public Transform myTransform;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = Input.mousePosition;
        if(Input.GetMouseButton(0))
        {
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             if(Physics.Raycast(ray, out hit))
             {
                if(hit.transform.gameObject.tag == "Enemy")
                {
                    //hit.transform.localScale += new Vector3(-0.05f, -0.05f, -0.05f);
                    //Destroy(hit.transform.gameObject, (float)0.5);
                    gameManager.SendMessage("destroy", hit.transform.gameObject);
                }
             }
        }
    }
}
