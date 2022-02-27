using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerView : MonoBehaviour {
	
	private PlayerModel playermodel;

	void Awake()
	{
		playermodel = gameObject.GetComponent<PlayerModel>();
	}


	void Start () {
		
	}

	void FixedUpdate()
	{

		playermodel.shootingHor = CrossPlatformInputManager.GetAxis ("ShootingHorizontal");
		playermodel.shootingVer = CrossPlatformInputManager.GetAxis ("ShootingVertical");
	
//		playermodel.hor = CrossPlatformInputManager.GetAxis ("Horizontal");
//		playermodel.ver = CrossPlatformInputManager.GetAxis ("Vertical");
		playermodel.hor = Input.GetAxis ("Horizontal");
		playermodel.ver = Input.GetAxis ("Vertical");
	
	}
	void Update () {
		
	}

	public void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "WeaponPlayer") {

			foreach(GameObject g in playermodel.guns)
			{
				if (other.name.StartsWith (g.name)) {
					g.SetActive (true);
					playermodel.gunPlayer = g.GetComponent<GunPlayer> ();
				}
				else
					g.SetActive (false);
			}
		
		}

		if (other.gameObject.tag == "Runes")
		{
			foreach (GameObject g in playermodel.runes) {
			
				if (other.name.StartsWith (g.name)) {
				
					g.SetActive (true);
					playermodel.runesPlayer = g.GetComponent<RunesPlayer> ();
					playermodel.runesPlayer.AbilityRune ();
				
				} 

				else {
				
					g.SetActive (false);
				
				}
			}

		}
	}




}
