using UnityEngine;

public class Génération : MonoBehaviour {

	public GameObject Obstacle;
	private int score = 0;

	void Start() {
		InvokeRepeating("CréerObstacle", 1f, 1.5f);
	}

	void OnGUI () 
	{
		GUI.color = Color.red;
		GUILayout.Label(" Score : " + score.ToString());
	}

	void CréerObstacle() {
		Instantiate(Obstacle);
		score++;
	}
}