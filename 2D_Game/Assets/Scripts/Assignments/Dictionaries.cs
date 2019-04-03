using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

	public Hashtable personalDetails = new Hashtable();

	// Use this for initialization
	void Start () {
		personalDetails.Add("firstName", "Greg");
		personalDetails.Add("lastName", "Lukosek");
		personalDetails.Add("gender", "male");
		personalDetails.Add("isMarried", true);
		personalDetails.Add("age", 29);
	}
	
}
