using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start () {
        textComponent.text = ("Learn to master the magic arts!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
