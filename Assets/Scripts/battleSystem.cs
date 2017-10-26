using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleSystem : MonoBehaviour {

	private int userChoice;
	private int opponentChoice;

    public GameObject a;
    public GameObject b;
    public GameObject c;


    //1 is rock 2 is paper and 3 is scissors
    enum choice : int { Rock = 1 , Paper, Scissors };

    int compChoice;
    

    void Start () {
       
    }

   private choice RandomChoice()
    {
        return (choice)(UnityEngine.Random.Range(0, 4));
    }

    // Update is called once per frame
    void FixedUpdate () {
        
    }

    void computer()
    {
        compChoice = (int)(choice)Random.Range(1, 4);
        if(compChoice == 1)
        {
            a = (GameObject)Instantiate(a);
            Destroy(a, 1.5f);
        }
        if (compChoice == 2)
        {
            a = (GameObject)Instantiate(b);
            Destroy(a, 1.5f);
        }
        if (compChoice == 3)
        {
            a = (GameObject)Instantiate(c);
            Destroy(a, 1.5f);
        }
    }


    public void rockSelected()
    {
        userChoice = (int)choice.Rock;
        compChoice = (int)(choice)Random.Range(1, 4);
        Debug.Log(compChoice);
        computer();
        if (userChoice == 1 && compChoice == 1)
        {
            
            Debug.Log("Tie");
            
        }
        if (userChoice == 1 && compChoice == 2)
        {
           
            Debug.Log("Loose");
            
        }
        if (userChoice == 1 && compChoice == 3)
        {
            
            Debug.Log("Win");
            
        }
        
    }

    public void paperSelected()
    {
        userChoice = (int)choice.Paper;
        compChoice = (int)(choice)Random.Range(1, 4);
        Debug.Log(compChoice);
        computer();
        if (userChoice == 2 && compChoice == 1)
        {
            Debug.Log("Win");
        }
        if (userChoice == 2 && compChoice == 2)
        {
            Debug.Log("Tie");
        }
        if (userChoice == 2 && compChoice == 3)
        {
            Debug.Log("Loose");
        }
    }

    public void scissorsSelected()
    {
        userChoice = (int)choice.Scissors;
        compChoice = (int)(choice)Random.Range(1, 4);
        Debug.Log(compChoice);
        computer();
        if (userChoice == 3 && compChoice == 1)
        {
            Debug.Log("Loose");
        }
        if (userChoice == 3 && compChoice == 2)
        {
            Debug.Log("Win");
        }
        if (userChoice == 3 && compChoice == 3)
        {
            Debug.Log("Tie");
        }
    }

}
