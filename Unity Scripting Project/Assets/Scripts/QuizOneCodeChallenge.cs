using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class QuizOneCodeChallenge : MonoBehaviour
{
    int Score = 0;
    string PlayerName = "Your Name";
    int Health = 100;


    // Start is called before the first frame update
    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IncreaseScore()
    {
        Score += 10;
    }

    void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    void DecreaseHealth()
    {
        Health -= 20;
    }
}
