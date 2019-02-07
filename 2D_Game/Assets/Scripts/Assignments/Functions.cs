using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather;

	void Start(){

		Weather(weather);
	}

	void Weather(string weatherState){

		if(weatherState == "Sunny"){
			print("The sun is shining today!");
		}
		else if(weatherState == "Raining"){
			print("It is soggy and wet today!");
		}
		else if(weatherState == "Windy"){
			print("It is blowing up a storm today!");
		}
		else if(weatherState == "Snowing"){
			print("It is time to ler it go today!");
		}
		else if(weatherState == "Foggy"){
			print("Are you in silent hill today?");
		}
		else{
			print("I don't understand"+ weatherState);
		}

	}
}
