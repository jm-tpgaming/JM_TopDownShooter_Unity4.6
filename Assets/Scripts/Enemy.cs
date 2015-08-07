using UnityEngine;
using System.Collections;

public class Enemy : Entity {


	private Player localPlayer;
	public float expOnDeath;

	


	void Start() {
		localPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	
	public override void Die () {
		localPlayer.AddExp(expOnDeath);
		base.Die ();
	}
}