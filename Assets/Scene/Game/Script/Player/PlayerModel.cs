using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour {

	[HideInInspector]
	public float hor,ver,shootingHor,shootingVer;
	[HideInInspector]
	public Rigidbody rigid;
	[HideInInspector]
	public	Animator ani;
	[HideInInspector]
	public PlayerManager playerManager;
	[HideInInspector]
	public GameObject[] guns;
	[HideInInspector]
	public GunPlayer gunPlayer;
	[HideInInspector]
	public GameObject[] runes;
	[HideInInspector]
	public RunesPlayer runesPlayer;


	[SerializeField]
	private float speed ;
	public float m_Speed
	{
		get{ return speed; }
		set{ speed = value; }
	}

	[SerializeField]
	private float hp ;
	public float m_Hp
	{
		get{ return hp; }
		set{ hp = value; }
	}


	void Awake()
	{
		rigid = gameObject.GetComponent<Rigidbody> ();
		ani = gameObject.GetComponent<Animator> ();

		playerManager = GameObject.Find("PlayerManager").gameObject.GetComponent<PlayerManager>() ;

		guns = GameObject.FindGameObjectsWithTag ("WeaponPlayer");
		runes = GameObject.FindGameObjectsWithTag ("RunesPlayer");

	}

	void Start()
	{
		foreach (GameObject n in guns) {

			if (n.name == "Weapon_0") 
			{
				n.SetActive (true);
				gunPlayer = n.GetComponent<GunPlayer> ();
			} 
			else 
			{
				n.SetActive (false);
			}
				
		}

		foreach (GameObject r in runes)
		{
			r.SetActive (false);
		}

	}


}
