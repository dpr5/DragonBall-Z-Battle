using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class timer : MonoBehaviour
{

    private float timeLeft;
    bool okToPress = false;
    bool notOkToPress = true;

    public Text timerText;
    public Button rockbtn;
    public Button paperbtn;
    public Button scissorsbtn;


    void Start()
    {
        //Debug.Log(timeLeft);
    }


    void Update()
    {
        timeLeft += Time.deltaTime;
        timerText.text = timeLeft.ToString();
        buttonPress();
        disableButtons();
    }

    

    void buttonPress()
    {
        
        if (timeLeft <= 0)
        {
            notOkToPress = true;
        }
        else okToPress = true;
    }

    void disableButtons()
    {
        if (notOkToPress == true)
        {
            rockbtn.interactable = false;
            paperbtn.interactable = false;
            scissorsbtn.interactable = false;
        }
        if (okToPress == true)
        {
            rockbtn.interactable = true;
            paperbtn.interactable = true;
            scissorsbtn.interactable = true;
        }
    }
}
