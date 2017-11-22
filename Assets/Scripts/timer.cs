using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class timer : MonoBehaviour
{

    
    public Button rockbtn;
    public Button paperbtn;
    public Button scissorsbtn;

    bool buttonPressed = false;


    void Start()
    {
        Button rbtn = rockbtn.GetComponent<Button>();
        Button pbtn = paperbtn.GetComponent<Button>();
        Button sbtn = scissorsbtn.GetComponent<Button>();

        rbtn.onClick.AddListener(TaskOnClick);
        pbtn.onClick.AddListener(TaskOnClick);
        sbtn.onClick.AddListener(TaskOnClick);
    }


    void Update()
    {
        
        
    }

    IEnumerator disableButton()
    {
        rockbtn.interactable = false;
        paperbtn.interactable = false;
        scissorsbtn.interactable = false;
        yield return new WaitForSeconds(3);
        rockbtn.interactable = true;
        paperbtn.interactable = true;
        scissorsbtn.interactable = true;
    }

    
    public void TaskOnClick()
    {
        buttonPressed = !buttonPressed;
        if (buttonPressed == true)
        {
            StartCoroutine(disableButton());
        }

        
    }

   
}
