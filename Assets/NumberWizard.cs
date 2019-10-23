using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int low = 1;
    int high = 1000;
    int guess;
    public int maxGuesses = 5;
    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
	}
    
    void StartGame()
    {
        guess = Random.Range(low, high+1);
        text.text = guess.ToString();
    }

    public void higher()
    {
        low = guess;
        NextGuess();
    }

    public void lower()
    {
        high = guess;
        NextGuess();
    }

    void NextGuess()
    {
        if (maxGuesses <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            guess = (high + low) / 2;
            text.text = guess.ToString();
            maxGuesses--;
        }
        
    }
}
