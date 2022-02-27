using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runes : MonoBehaviour {
	
	void OnEnable ()
	{
		StartCoroutine ("Destroy");

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player")
			PoolManager.ReleaseObject (this.gameObject);
	}

	IEnumerator Destroy ()
	{
		yield return new WaitForSeconds (5);
		PoolManager.ReleaseObject (this.gameObject);
	}
}
