using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStateAttack_Range : MonsterStateAttack {

	GameObject bullet;
	Transform posiBullet;
	void Start ()
	{
		bullet = transform.GetChild (0).gameObject;
		posiBullet = transform.GetChild (0).gameObject.GetComponent<Transform>();
		PoolManager.WarmPool (bullet,10);
	}

	public override void Attack ()
	{
		base.Attack ();
		transform.LookAt (monsterModel.myTarget.transform);
		Bullet bull = PoolManager.SpawnObject (bullet,posiBullet.position,posiBullet.rotation).GetComponent<Bullet>();
		bull.DirectFire (transform.forward,"Monster",monsterModel.MyDamge);

	}
}
