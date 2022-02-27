using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class AnimatorControlEvent : UnityEvent<Animator> {}
public class MonsterDamageEvent : UnityEvent<float> {}

public class MonsterManager : MonoBehaviour {


    public static AnimatorControlEvent IdleEventEnter = new AnimatorControlEvent ();
    public static AnimatorControlEvent IdleEventExit = new AnimatorControlEvent ();
    public static AnimatorControlEvent MoveEventEnter = new AnimatorControlEvent ();
    public static AnimatorControlEvent MoveEventExit = new AnimatorControlEvent ();
    public static AnimatorControlEvent AttackEventEnter = new AnimatorControlEvent ();
    public static AnimatorControlEvent AttackEventExit = new AnimatorControlEvent ();
    public static AnimatorControlEvent DieEventEnter = new AnimatorControlEvent();
    public static AnimatorControlEvent DieEventExit = new AnimatorControlEvent();

	public static MonsterDamageEvent MonsterDamage = new MonsterDamageEvent();


}
