using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private PlayerModel playermodel;



	void Awake()
	{
		playermodel = gameObject.GetComponent<PlayerModel> ();

		MonsterManager.MonsterDamage.AddListener (TakeDamage);

	}

	void Start () {
		
	}

	void FixedUpdate ()
	{
		Turning ();
		Move (playermodel.hor,playermodel.ver);
		Animating (playermodel.hor,playermodel.ver,playermodel.shootingHor,playermodel.shootingVer);
	}

	void Update () {
		
	}

	void Move (float h , float v)
	{
		Vector3 movement = new Vector3 (h,0f,v);
		Vector3 velocity = movement * playermodel.m_Speed * Time.deltaTime;

		if (playermodel.shootingHor != 0 || playermodel.shootingVer != 0)
			transform.position = transform.position;
		else
			transform.position = transform.position + velocity;
	}

	void Turning ()
	{
		Vector3 directMove = new Vector3 (playermodel.hor,0f,playermodel.ver);
		Vector3 directShooting = new Vector3 (playermodel.shootingHor,0f,playermodel.shootingVer);

		Quaternion newRotationMove = Quaternion.LookRotation (directMove);
		Quaternion newRotationShoot = Quaternion.LookRotation (directShooting);

		if (playermodel.hor != 0 || playermodel.ver != 0) 
			playermodel.rigid.MoveRotation (newRotationMove);
		
		
		if (playermodel.shootingHor != 0 || playermodel.shootingVer != 0) {
			playermodel.rigid.MoveRotation (newRotationShoot);
			Shooting ();
		}
			
		
	}

	void Animating (float h ,float v ,float sh ,float sv)
	{
		bool move     =  h  != 0 || v  != 0;
		bool shooting =  sh != 0 || sv != 0;

		if (shooting == true) {
			playermodel.ani.SetTrigger ("Shoot");
		} 

		else
		{
			if (move == true)
				playermodel.ani.SetTrigger ("Move");
			else
				playermodel.ani.SetTrigger ("Idle");
		}

	}

	void Shooting ()
	{
		
		playermodel.gunPlayer.Shooting (transform.forward);

	}


	void TakeDamage (float d)
	{
		playermodel.m_Hp -= d;
		if (playermodel.m_Hp <= 0) {
		
			playermodel.ani.SetTrigger ("Die");
		
		}
	}
}
