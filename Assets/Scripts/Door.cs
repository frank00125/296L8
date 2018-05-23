using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	
	
	[SerializeField] Vector3 targetPos;
	[SerializeField] Vector3 loweredPos;

	// Use this for initialization
	void Start () {
		targetPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = Vector3.Lerp(transform.localPosition, targetPos, Time.deltaTime);
	}

	public void LowerDoor(){
		targetPos = loweredPos;
	}
}
