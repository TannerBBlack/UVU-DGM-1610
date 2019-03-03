using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour {

    public string lightColor;
    public bool isUtahn;
    public string coolPerson;

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
        if(coolPerson == "Brian")
        {
            print("yeah, you're cool man");
        }
        else if(coolPerson == "Tanner")
        {
            print("you're the coolest of them all dude!");
        }
        else if(coolPerson == "Jim")
        {
            print("I gues you're alright...");
        }
        else if(coolPerson == "Bob")
        {
            print("KING BOB!!!!");
        }
        else if(coolPerson == "Davis")
        {
            print("you're just a clone of you're brother");
        }
        else if(coolPerson == "Josh")
        {
            print("you da man!");
        }
        else if(coolPerson == "Kirby")
        {
            print("hiiii!");
        }
        else if(coolPerson == "Link")
        {
            print("Hut, hut, hyat!");
        }
        else if(coolPerson == "Mario")
        {
            print("it's a me, Mario!");
        }
        else
        {
            print("you're not cool enough to be known");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
