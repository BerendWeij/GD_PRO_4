using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// Lambda voorbeelden
/// </summary>
public class LambdaExamples : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

		// 1 simpel lambda voorbeeld met een Action

		// we roepen eerst een method aan zoals jullie het 'gewend' zijn
		logMessage("test");

		// vervolgens maken we ook een lambda (anonieme functie) die hetzelfde kan
		// we maken er een Action van aangezien hij niets hoeft te returnen
		Action<string> log = (msg) => { 
			Debug.Log(msg);
		};
		// en we roepen onze lamda functie aan
		log("Doet mijn lambda het?");

		// 2 simpel lambda voorbeeld met een Func

		// we roepen eerst weer gewoon een method aan waar jullie aan 'gewend' zijn
		Debug.Log( multiplyValue(3, 4) );

		// vervolgens maken we ook een lambda die hetzelfde kan
		// we maken er een Func van, aangezien de functie iets moet kunnen returnen
		Func<float, float, float> multiply = (value, multiplier) => value * multiplier;
		// en we roepen de lambda functie aan
		Debug.Log( multiply(4, 5) );


		// 3 We gebruiken een lambda om over een List heen te loopen
		List<string> names = new List<string>();
		names.Add("Sjef");
		names.Add("Cindy");
		names.Add("Boef");
		names.Add("Bibi");

		// List<T>.ForEach is een standaard C# functie. Er zijn nog veel meer functies zoals deze
		names.ForEach( name => {
			Debug.Log(name);
		});

	}

	void logMessage(string message ){
		Debug.Log(message);
	}

	float multiplyValue(float value, float multiplier){
		return value * multiplier;
	}




}
