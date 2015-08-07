using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	

	public static int enemyCount= 0;
	public GameObject enemy;
	public float spawnTimer = 3f;

	void Start()
	{
		InvokeRepeating ("Spawn", spawnTimer, spawnTimer);
		}




	void Spawn()
	{
		GameObject enemy = Instantiate(Resources.Load("Prefab_Enemy"),Vector3.zero, Quaternion.identity) as GameObject;
		enemyCount++;
	}
}
