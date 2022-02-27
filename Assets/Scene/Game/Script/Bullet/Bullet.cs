using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;

	private float damage;
	private string myBullet;

	Vector3 directFire;

	void OnEnable ()
	{
		if (isActiveAndEnabled) {
		
			StartCoroutine ("Destroy");
		}
	}

	public void DirectFire (Vector3 p,string s,float d)
	{
		directFire = p;
		myBullet = s;
		damage = d;

	}

	void FixedUpdate()
	{
		Vector3 velocity = directFire * speed * Time.deltaTime;
		transform.position = transform.position + velocity;

	}

	public void OnTriggerEnter (Collider other)
	{
		if (myBullet == "Player") 
		{
			PlayerManager.PlayerDamage.Invoke (other.gameObject,damage);
		} 

		else if (myBullet == "Monster") 
		{
			MonsterManager.MonsterDamage.Invoke (damage);
		}

		PoolManager.ReleaseObject (this.gameObject);
	}



	IEnumerator Destroy ()
	{
		yield return new WaitForSeconds (0.5f);
		PoolManager.ReleaseObject (this.gameObject);
	}
}
