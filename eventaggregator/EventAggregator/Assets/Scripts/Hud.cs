using UnityEngine;
using System.Collections;
using Event;

public class Hud : MonoBehaviour, ISubscriber<HealthChanged> {

	// Use this for initialization
	void Awake () {
		Game.eventAggregator.SubscribeEvent(this);
	}

	public void OnEventHandler(HealthChanged e)
	{
		Debug.Log(e.currentHealth);
	}

}
