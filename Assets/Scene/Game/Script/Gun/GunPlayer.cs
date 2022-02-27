using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayer : MonoBehaviour {

	public float fireRate;
	private float lastFire;

	private Transform positionGun;
	private Transform posiBullet;

	private GameObject bullet;

	public float damageBullet;

	void Awake ()
	{

		
	}


	void Start ()
	{
		bullet = transform.GetChild (0).gameObject;
		posiBullet = transform.GetChild (0).gameObject.transform;

		positionGun = GameObject.Find ("PositionGunPlayer").GetComponent<Transform>();

		PoolManager.WarmPool (bullet,5);
	}



	void Update ()
	{
		transform.position = positionGun.position;
		transform.rotation = positionGun.rotation;
	}

	public void Shooting (Vector3 t)
	{
		if (Time.time > fireRate + lastFire) {

			Bullet bull = PoolManager.SpawnObject (bullet,posiBullet.position,posiBullet.rotation).gameObject.GetComponent<Bullet>();
			bull.DirectFire (t,"Player",damageBullet);

			lastFire = Time.time;
		}
	}
		
}
