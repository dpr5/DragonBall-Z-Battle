using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleSystem : MonoBehaviour
{
    
    //1 is rock 2 is paper and 3 is scissors
    enum choice : int { Rock = 1, Paper, Scissors };


    int compChoice;

    private int userChoice;
    private int opponentChoice;
    public Text text;

    public GameObject a;
    public GameObject b;
    public GameObject c;

    public bool tie = false;
    public bool lose = false;
    public bool win = false;

    float _countDownTimeLeft = 30.0f;
    bool _timerIsGoing;

    void Start()
    {
        
    }

    private choice RandomChoice()
    {
        return (choice)(UnityEngine.Random.Range(0, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void computer()
    {
        compChoice = (int)(choice)Random.Range(1, 4);
        if (compChoice == 1)
        {
            if (a != null)
            {
                a = (GameObject)Instantiate(a);
                Destroy(a, 1.5f);
            }
        }
        if (compChoice == 2)
        {
            if (b != null)
            {
                b = (GameObject)Instantiate(b);
                Destroy(b, 1.5f);
            }
        }
        if (compChoice == 3)
        {
            if (c != null)
            {
                c = (GameObject)Instantiate(c);
                Destroy(c, 1.5f);
            }
        }
    }


    public void rockSelected()
    {
        userChoice = (int)choice.Rock;
        compChoice = (int)(choice)Random.Range(1, 4);
        Debug.Log(compChoice);
        computer();

       


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
