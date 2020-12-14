using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    public Toggle a;
    public Toggle b;
    public Toggle c;
    public Toggle d;
    public Toggle bad;




    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject gameManager;
    public void Start()
    {
        timerIsRunning = false;
        
    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {                                       // Starts the timer automatically
            ActiveToggle();
            timerIsRunning = true;
        }



        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                gameManager.SendMessage("End");
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }



    public void ActiveToggle()
    {
        if (a.isOn)
        {
            timeRemaining = 10;
        }

        else if (b.isOn)
        {
            timeRemaining = 30;
        }


        else if (c.isOn)
        {
            timeRemaining = 60;
        }



        else if (d.isOn)
        {
            timeRemaining = 90;
        }


        if (d.isOn && bad.isOn)
        {
            timeRemaining = 9000;
            Debug.Log("fart");
        }

        if (c.isOn && bad.isOn)
        {
            timeRemaining = 9000;
            Debug.Log("fart");
        }

        if (b.isOn && bad.isOn)
        {
            timeRemaining = 9000;
            Debug.Log("fart");
        }






    }





}