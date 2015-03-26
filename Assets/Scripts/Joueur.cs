using UnityEngine;

public class Joueur : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);

	void Update () {
		if (Input.GetKeyUp("space")) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Mourir();
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		Mourir();
	}
		
	void Mourir() {
		Application.LoadLevel(Application.loadedLevel);
	}
}