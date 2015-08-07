using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {
	/*Here we setup the health and damage system for the enemies
	as well as the player. This script gets called on by the 
	player script to track player damage taken
	*/
	Transform player; // Makes the enemies seek out the player
	public float health;
	NavMeshAgent nav;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform; // This gives the enemies the ref of where the player is
		nav = GetComponent<NavMeshAgent> ();
		nav.SetDestination (player.position);
	}

	void Update()
	{
		if (player != null && nav != null)
		nav.SetDestination (player.position);
	}


	public virtual void TakeDamage(float dmg) { //We're using virtual voids to allow for changes 
											   //later on to specific enemy death options.
		health -= dmg;

		if (health <= 0) {
			Die();
		}
	}
	public virtual void Die() {

		Destroy (gameObject);
	}
}
