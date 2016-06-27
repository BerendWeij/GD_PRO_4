using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Een component voor alle traps
/// </summary>
public class Trap : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		
		// we maken even een referentie aan naar de GameObject die we raken
		GameObject target = other.gameObject;

		// We roepen onze Execute method aan om te kijken of onze target components heeft die IDamageable implementeren
		Execute<IDamageable> (target, x => x.TakeDamage(5f) );

	}

	/// <summary>
	/// Execute een message op een bepaalde target
	/// </summary>
	/// <param name="target">Target. Op welke GameObject wil je iets uitvoeren?</param>
	/// <param name="message">Message. Welke functie zou je op alle gevonden components willen uitvoeren? In deze Action kun je alles uitspoken met het component wat je wilt</param>
	/// <typeparam name="T">Naar welke interface ben je opzoek bij je target?</typeparam>
	void Execute<T> ( GameObject target, Action<T> message ){

		// we vragen de target of hij een lijst met components heeft die de gevraagde interface implementeren (in mijn voorbeeld IDamageable)
		T[] components = target.GetComponents<T>();

		// we loopen over alle components heen en roepen de Action message() aan
		// en geven de component door als argument
		foreach(T component in components){
			message(component);
		}
	
	}
		
}
