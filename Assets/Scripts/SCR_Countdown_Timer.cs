using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Countdown_Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 10f;

    [SerializeField] Text countdownText;
    
    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);

        countdownText.text = currentTime.ToString();
        
        if(currentTime <= 5)
        {
            countdownText.color = Color.red;
        }

        //Must add command to kill the program after the timer clock runs out.
        //Return Player back to home menu.

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

}
