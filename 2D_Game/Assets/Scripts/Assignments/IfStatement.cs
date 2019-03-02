using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {

    public string lightColor;
    public bool isUtahn;

	// Use this for initialization
	void Start () {
        if(lightColor == "Green")
        {
            if (isUtahn == true)
            {
                print("Wait, then go");
            }
            else if (isUtahn == false)
            {
                print("light is green. go you yahoo!");
            }
        }
		else if(lightColor == "Yellow")
        {
            print("light is yellow. speed up!");
        }
        else if(lightColor == "Red")
        {
            print("light is red. stop dude!");
        }
        else
        {
            print("I don't know that color...");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
