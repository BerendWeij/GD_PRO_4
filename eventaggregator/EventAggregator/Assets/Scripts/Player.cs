using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		
	}

	void Start() {
		Game.eventAggregator.PublishEvent(new HealthChanged() { currentHealth = 35 });
	}

}
