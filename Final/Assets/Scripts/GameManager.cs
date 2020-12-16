using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Toggle none;
    public Toggle once;
    public Toggle twice;
    public Toggle three;
    public Canvas survey;
    

    // Start is called before the first frame update
    public GameObject bc;
    public GameObject bcs;
    public GameObject bs;
    public GameObject bsq;
    public GameObject gc;
    public GameObject gcs;
    public GameObject gs;
    public GameObject gsq;
    public GameObject pc;
    public GameObject pcs;
    public GameObject ps;
    public GameObject psq;
    GameObject[] bacteria;
    bool hoard = false;

    double hidden = 50;
    double shown = 0;
    double gone;
    
    void Start()
    {   
        
        bacteria = new GameObject[] { bc, bcs, bs, bsq, gc, gcs, gs, gsq, pc, pcs, ps, psq };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {                                       
            ActiveToggle(); //checks whats selected and changes code accordingly
            survey.GetComponent<Canvas>().enabled = false;

        }
    }

    void make()
    {
        float x;
        float y;
        float z;
        int random;
        if (hidden > 0)
        {
            for (int i = 0; i < hidden; i++)
            {
                if (i >= 10 && !hoard)
                {
                    break;
                }
                else if(i >= 40)
                {
                    break;
                }
                x = Random.Range(-5, 5);
                y = Random.Range((float)-1.5, 4);
                bool front = Random.value > 0.5f;
                if (front)
                {
                    z = (float)-3.78;
                }
                else
                {
                    z = -17;
                }
                random = Random.Range(0, 11);
                hidden -= 1;
                shown += 1;
                Instantiate(bacteria[random], new Vector3(x, y, z), Quaternion.identity);
            }
            
        }
        //Debug.Log("Hidden: " + hidden);
        //Debug.Log("Shown: " + shown);
        //Debug.Log("Gone: " + gone);

    }

    void End()
    {
        Debug.Log("GAME OVER");
        if((hidden+shown) < (hidden+shown+gone)*0.8)
        {
            Debug.Log("WIN!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else 
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

    void destroy(GameObject obj)
    {
        obj.transform.localScale += new Vector3(-0.05f, -0.05f, -0.05f);
        Destroy(obj, (float) 0.5);
        shown -= 1;
        gone += 1;
        //Debug.Log("Hidden: " + hidden);
        //Debug.Log("Shown: " + shown);
        //Debug.Log("Gone: " + gone);
    }




    public void ActiveToggle() //looks for whats toggled
    {
        if (none.isOn)
        {
            hidden = 70;
            //parameters for spawn code based off not brushing
        }

        else if (once.isOn)
        {
            hidden = 50;
            //parameters for spawn code based off brushing once  
        }


        else if (twice.isOn)
        {
            hidden = 20;
            //parameters for spawn code based off brushing twice
        }



        else if (three.isOn)
        {
            hidden = 1;
            //parameters for spawn code based off brushing three times
            
        }

        InvokeRepeating("make", 1, 15);
    }

    public void hoards()
    {
        hoard = true;
    }








}
