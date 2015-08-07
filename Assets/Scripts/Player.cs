using UnityEngine;
using System.Collections;

public class Player : Entity {

	// This is the basis of our leveling system
	private int level;
	private float currentExp;
	private float expToLevel;

	void Start() {
		LevelUp ();
	}

	public void AddExp(float exp) {
		currentExp += exp;
		if (currentExp >= expToLevel) {
			currentExp -= expToLevel;
			LevelUp();
		}
		//Debug.Log ("EXP: " + currentExp + "  Level:  " + level);
	}
	private void LevelUp() {
		level++;
		expToLevel = level * 50 + Mathf.Pow (level * 2, 2);

		AddExp (0);
	}

}
