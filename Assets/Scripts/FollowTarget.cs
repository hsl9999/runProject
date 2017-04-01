using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class FollowTarget : MonoBehaviour {  

	public Transform character;   //摄像机要跟随的人物 

	public float smoothTime = 0.01f;  //摄像机平滑移动的时间

	private Vector3 cameraVelocity = Vector3.zero;     

	private Camera mainCamera;  

	private Vector3 cameraPos;

	//主摄像机（有时候会在工程中有多个摄像机，但是只能有一个主摄像机吧）     

	void  Awake ()     
	{   
		mainCamera = Camera.main;   
		cameraPos = mainCamera.transform.localPosition;
	}  

	void  Update()   
	{ 
		transform.position = Vector3.SmoothDamp(transform.position, character.position + cameraPos, ref cameraVelocity, smoothTime);
	}  

}