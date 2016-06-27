using UnityEngine;
using System.Collections;

/// <summary>
/// I damageable. Interface voor Classes die damage moeten kunnen ontvangen
/// </summary>
public interface IDamageable {

	void TakeDamage(float damage);

}
