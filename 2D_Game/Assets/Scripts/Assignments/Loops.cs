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

        while(bottles <= 100){
            print(bottles+" bottles of tylenol on the wall");
            bottles ++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
