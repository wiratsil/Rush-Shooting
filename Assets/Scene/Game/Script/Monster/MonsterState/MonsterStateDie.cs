﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStateDie : StateMonster 
{
    public override void Init()
    {
        base.Init();
        MonsterManager.DieEventEnter.AddListener(OnEnter);
        MonsterManager.DieEventExit.AddListener(OnExit);
    }
		

    public override void OnEnter(Animator aim)
    {
        base.OnEnter(aim);
        if(isActiveAndEnabled)
        {
			StartCoroutine ("Die");
        }
    }

	void Update ()
	{
		
	}

	IEnumerator Die()
    {
        yield return new WaitForSeconds(1.5f);
        PoolManager.ReleaseObject(this.gameObject);
    }


}
