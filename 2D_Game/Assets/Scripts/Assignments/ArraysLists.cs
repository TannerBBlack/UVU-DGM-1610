using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysLists : MonoBehaviour {

	public int[] oddNumbers = {1, 3, 5, 7, 9};
    public string[] coolJoes = { "Bob", "Joe", "Tanner", "Yugi", "James"};
   public bool[] didWeWin = {true, false};
    public string[] dogs = {"Snouser", "Sheperd", "Lab", "Terrier"};
    public int[] evenNumbers = {2, 4, 6, 8, 10};
    public string[] videoGames = { "Legend of Zelda", "Startfox", "Halo", "Starcraft", "Valkyria Chronicles" };
    public string[] goodBooks = { "The Way of Kings", "Steelheart", "Mistborn", "Fablehaven" };
    public int[] luckyNumbers = { 7, 42, 17, 66, 23 };
    public float[] funNumbers = { 2.8f, 3.7f, 4.4f };
    public string[] movies = { "Star Wars", "Shazam", "Lord of the Rings" };

	// Use this for initialization
	void Start () {
		print(oddNumbers[2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
