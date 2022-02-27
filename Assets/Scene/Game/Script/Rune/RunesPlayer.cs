using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunesPlayer : MonoBehaviour {
	
	[HideInInspector]
	public  Transform posiPlayer;

	public float runeTime;

	void Start () {
		posiPlayer = GameObject.Find ("Player").GetComponent<Transform>();
	}
	

	void Update () {
		transform.position = posiPlayer.position+new Vector3(0,1,0);
	}

	public virtual void  AbilityRune () 
	{
		
	}

}
