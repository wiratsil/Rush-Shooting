using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	void OnEnable ()
	{
		StartCoroutine ("Destroy");

	}

	void Update ()
	{
		transform.Rotate (Vector3.up*100*Time.deltaTime,Space.Self);
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
