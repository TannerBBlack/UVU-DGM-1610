using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {

        Debug.Log("Welcome to the NumberWizard. Prepare to be amazed!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number can be 1000");
        Debug.Log("Lowest number can be 1");
        Debug.Log("tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up arrow if my quess is to low, Push down arrow if my guess is to high, Push enter if my guess is Correct");
        max = max + 1;

	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("is it higher or lower than...");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("is it higher or lower than...");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else   if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed correctly!");
        }
    }
}
