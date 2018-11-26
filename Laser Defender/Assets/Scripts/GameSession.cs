using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

    int score = 0;
    private static GameSession  _instance;

    public GameSession Gamesession {
        get { return _instance; }
        set { _instance = value; }
    }
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if(_instance!= null && _instance!=this) {
            Destroy(this);
        }
        else {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        //Destroy(gameObject);
    }

 }
