using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class test : MonoBehaviour {


    private float timeRemaining = 5f;
    public Text text;

    void Start () 
	{
        
    }
	
	
	void Update () 
	{
        timeRemaining -= Time.time;
        text.text = "Time Remaining: " + timeRemaining;
        //Debug.Log(timeRemaining);
    }

    



}
