using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControlMove : MonoBehaviour {

	//定义主角角色控制器  
	CharacterController hero;
	public int moveSpeed = 10;

	// Use this for initialization
	void Start () {
		hero = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		hero.SimpleMove (Vector3.forward * moveSpeed);
	}
}
