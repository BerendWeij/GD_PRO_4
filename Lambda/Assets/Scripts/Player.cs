using UnityEngine;
using System.Collections;

/// <summary>
/// Onze simpele Player Class
/// </summary>
public class Player : MonoBehaviour, IDamageable {

	public void TakeDamage(float damage){
		Debug.Log("damage: " + damage);
	}

}
