using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    private int max, min, guess;
    void Start()
    {
        Debug.Log("Welcome to number wizard.");
        StartGame();
     }

    private void StartGame() {
        max = 1000;
        min = 1;
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log($"Highest number you  can pick is: {max}");
        Debug.Log($"Lowest number you can pick is: {min}");
        DisplayGuess();
    }

    private void DisplayGuess() {
        guess = min + (max - min) / 2;
        Debug.Log($"Is it higher or lower than... {guess}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            DisplayGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            DisplayGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
            Debug.Log($"Coreect is: {guess}");
        }
    }
}
