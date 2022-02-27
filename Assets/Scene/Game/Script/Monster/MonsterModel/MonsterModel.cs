﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public class MonsterModel : MonoBehaviour {

    [SerializeField]
    float dmg  ,range ,hp ,atkSpeed ;

	[HideInInspector]
	public NavMeshAgent agent;

	[HideInInspector]
	public GameObject myTarget ;

    [HideInInspector]
	public Rigidbody rigid;

	[HideInInspector]
	public Animator anim;


    public float MyDamge 
    {
        get {return dmg;}
        set{dmg = value;}
    }

    public float MyRange
    {
        get { return range;}
        set{ range = value; }
    }

    public float MyHp
    {
        get{return hp;}
        set{hp = value;}
    }

    public float MyAtkSpeed 
    {
        get{return atkSpeed;}
        set{ atkSpeed = value; }
    }




	void Start()
	{
		agent = GetComponent<NavMeshAgent> ();
		rigid = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();

		myTarget = GameObject.Find ("Player");

	}

}

