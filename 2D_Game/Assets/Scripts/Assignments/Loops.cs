using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int bottles = 100;
    //public bool isRaining = true;

    // Start is called before the first frame update
    void Start()
    {
        //for loop
        // for(int i=1; i < bottles; i++){
        //     print(i+" bottles of tylenol on the wall");
        // } 

        // while(bottles <= 100){
        //     print(bottles+" bottles of tylenol on the wall");
        //     bottles ++;
        // }

        // Do while loop
        // bool shouldContinue = false;

        // do
        // {
        //     print ("Hello Worl! XD");

        // }while(shouldContinue == true);

        // ForEach Loop
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third? string";

        foreach (string item in strings)
        {
            print (item);
        }
        string[] colors = new string[3];

        colors[0] = "Red";
        colors[1] = "Green";
        colors[2] = "Blue";

        foreach (string item in colors)
        {
            print(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
