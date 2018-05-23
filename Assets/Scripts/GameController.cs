using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public TextMesh infoText;
	public Player m_player;
	public Transform enemyContainer;
	float restTimer = 3.0f;

	void Start () {
		infoText.text = "Find The Button \n Then you can get into castle";
	}
	
	void Update () {
		if(m_player.enterCastle){
			int enemyCount = enemyContainer.GetComponentsInChildren<Enemy>().Length;
			infoText.text = "Destory all " + enemyCount.ToString() + " enemies !!!";
			if(enemyCount <= 0){
				infoText.text = "Congradulations!! You destory all enemys";
				restTimer -= Time.deltaTime;
				if(restTimer <= 0){
					SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				}
			}
			else{
				infoText.text = enemyCount.ToString() + " enemys still alive!!";
			}
		}
	}
}
