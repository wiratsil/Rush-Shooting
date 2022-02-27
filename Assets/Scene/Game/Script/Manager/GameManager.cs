using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	public Transform[] spawnGuns;
	public GameObject[] guns;
	[Space]
	public Transform[] spanwRunes;
	public GameObject[] runes;
	[Space]
	public Transform[] spawnMonster;
	public GameObject[] monster;





	void Start ()
	{
		foreach (GameObject g in guns) {

			PoolManager.WarmPool (g,6);
		}

		foreach (GameObject g in runes)
		{
			PoolManager.WarmPool (g,4);
		}

		foreach (GameObject g in monster) 
		{
			PoolManager.WarmPool (g, 5);
		}

		InvokeRepeating ("SpawnGuns",0,5);
		InvokeRepeating ("SpawnRunes",0,5);
		InvokeRepeating ("SpawnMonster", 0, 10);
	}

	void Update()
	{


	}


	void SpawnGuns ()
	{
		foreach (Transform t in spawnGuns) {
		
			int randomGun = (int)Random.Range (0,guns.Length);
			PoolManager.SpawnObject (guns[randomGun],t.position,t.rotation);
		
		}
	}

	void SpawnRunes ()
	{
		foreach (Transform t in spanwRunes) {
		
			int randomRune = Random.Range (0,runes.Length);
			PoolManager.SpawnObject (runes[randomRune],t.position,t.rotation);
		
		}
	}

	void SpawnMonster ()
	{
		int randomPosi = Random.Range (0,spawnMonster.Length);
		int randomMon = Random.Range (0,monster.Length);
		PoolManager.SpawnObject (monster[randomMon],spawnMonster[randomPosi].position,spawnMonster[randomPosi].rotation);
	}
}
