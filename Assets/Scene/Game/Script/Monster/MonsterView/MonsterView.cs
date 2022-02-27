using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterView : MonoBehaviour {

    private MonsterModel monsterModel;

    void Awake()
    {
        monsterModel = gameObject.GetComponent<MonsterModel>();

    }

    void OnEnable()
    {
        monsterModel.MyDamge = monsterModel.MyDamge + Time.time * 0.09f;
        monsterModel.MyHp = monsterModel.MyHp + Time.time * 0.09f;

		PlayerManager.PlayerDamage.AddListener (TakeDamge);

    }

    void Update ()
    {

    }

	void TakeDamge (GameObject g, float d)
	{
		if (g == this.gameObject) {
			monsterModel.MyHp -= d;
			if (monsterModel.MyHp <= 0) {

				monsterModel.anim.SetTrigger ("Die");

			}
		
		}

	}

	void OnDisable ()
	{
		PlayerManager.PlayerDamage.RemoveAllListeners ();
	}

}
