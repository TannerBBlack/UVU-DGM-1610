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

    public List<string> winnersList = new List<string>();
    public List<string> timeOfDay = new List<string>();
    public List<string> shapes = new List<string>();
    public List<string> legos = new List<string>();
    public List<string> pictures = new List<string>();

    public ArrayList somethingCool = new ArrayList();
    public ArrayList colors = new ArrayList();
    public ArrayList snowmen = new ArrayList();
    public ArrayList n64Games = new ArrayList();
    public ArrayList stuffedAnimals = new ArrayList();

    // Use this for initialization
    void Start () {
		print(oddNumbers[2]);

        winnersList.Add("Tanner");
        winnersList.Add("Josh");
        winnersList.Add("Davis");
        timeOfDay.Add("noon");
        timeOfDay.Add("high noon");
        timeOfDay.Add("midnight");
        shapes.Add("Circle");
        shapes.Add("Of You");
        shapes.Add("triangle");
        legos.Add("2x4 brick");
        legos.Add("2x2 brick");
        legos.Add("2x3 brick");
        pictures.Add("Mona Lisa");
        pictures.Add("St. George and the Dragon");
        pictures.Add("Starry Sky");

        somethingCool.Add("Piece of string");
        somethingCool.Add("Very old vest");
        somethingCool.Add("Everything");
        colors.Add("Green");
        colors.Add("Red");
        colors.Add("Blue");
        snowmen.Add("Olaf");
        snowmen.Add("Frosty");
        snowmen.Add("Chill");
        n64Games.Add("Banjo Kazooie");
        n64Games.Add("Majora's Mask");
        n64Games.Add("Super Mario 64");
        stuffedAnimals.Add("Sneaky");
        stuffedAnimals.Add("Spy");
        stuffedAnimals.Add("Buffalo");

        print(n64Games[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
