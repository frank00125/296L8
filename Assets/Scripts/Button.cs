using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public Door mydoor;

	public void OnLook(){
		mydoor.LowerDoor();
	}
}
