using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 0.5f;
	public GameObject m_player;
	Vector3 targetPos;
	public Vector3 castlePos;
	public bool enterCastle;

	void Start(){
		targetPos = m_player.transform.position;
	}

	void Update () {
		RaycastHit hit;
		if(Physics.Raycast(transform.position, transform.forward, out hit)){
			Debug.Log(hit.transform.name);
			if(hit.transform.GetComponent<Button>() != null){
				hit.transform.GetComponent<Button>().OnLook();
				MoveToCastle();
			}
		}

		if(Input.GetButtonDown("Fire1")){
			RaycastHit enemyHit;
			if(Physics.Raycast(transform.position, transform.forward, out enemyHit)){
				if(enemyHit.transform.GetComponent<Enemy>() != null){
					Destroy(enemyHit.transform.gameObject);
				}
			}
		}

		m_player.transform.position = Vector3.Lerp(m_player.transform.position, targetPos, Time.deltaTime * speed);
	}

	void MoveToCastle(){
		targetPos = castlePos;
		enterCastle = true;
	}
}
