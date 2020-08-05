using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	Animator playerAnim;
	public float playerSpeed;
	public float rotationSpeed;
	public float speed;
	public float health = 1.0f;
	Rigidbody rb;
	public Joystick joystick;
	Vector3 lookDirection;
	bool isOnCollision;
	[HideInInspector]
	public bool bIsAttacking = false;
	public GameObject attackEffect;
	float ParticleSystemTimer = 2.0f;
	public GameObject projectile;
	public GameObject rightHand;
	public InventoryController invCtrl;
	public bool bIsBeingAttacked = false;

	public void Attack () {
		// bIsAttacking = true;
		playerAnim.SetFloat ("Speed", 0.4f);
		if (attackEffect) {
			attackEffect.SetActive (true);
		}
		if (projectile && rightHand) {
			GameObject bulletObj = GameObject.Instantiate<GameObject> (projectile);
			bulletObj.transform.position = rightHand.transform.position;

		}
	}

	void Start () {
		playerAnim = this.GetComponent<Animator> ();
		playerAnim.SetFloat ("Speed", 0.0f);
		rb = this.GetComponent<Rigidbody> ();
		attackEffect.SetActive (false);
	}

	void touchInput () {
		// float hor = Input.GetAxis("Horizontal");
		// float ver = Input.GetAxis("Vertical");

		float hor = joystick.Horizontal;
		float ver = joystick.Vertical;
		if (hor != 0 && ver != 0) {
			playerAnim.SetFloat ("Speed", 0.2f);
			if (bIsAttacking) {
				Attack ();
			}
			// else if (bIsBeingAttacked)
			// {
			// 	playerAnim.SetFloat("Speed", 1.0f);
			// }
		} else if (bIsAttacking) {
			Attack ();
		}
		// else if (bIsBeingAttacked)
		// {
		// 	playerAnim.SetFloat("Speed", 1.0f);
		// }
		else {
			playerAnim.SetFloat ("Speed", 0.0f);
			return;
		}
		Vector3 playerMovement = new Vector3 (hor, 0f, ver) * speed * Time.deltaTime;
		Quaternion lookRotation = Quaternion.LookRotation (playerMovement, Vector3.up);
		float step = rotationSpeed * Time.deltaTime;
		this.transform.rotation = Quaternion.RotateTowards (lookRotation, this.transform.rotation, step);

		// transform.Translate (playerMovement, Space.Self);
		// rb.AddForce(playerMovement*playerSpeed);
		if (rb && !(bIsBeingAttacked)) {
			// rb.velocity = playerMovement*playerSpeed;
			rb.AddForce (playerMovement * playerSpeed);
		} else if (rb && bIsBeingAttacked) {
			rb.velocity = playerMovement * playerSpeed;
		}

		// if (Input.GetKey("j"))
		// {
		// 	mainCamera.enabled = false;
		// 	mainCamera1.enabled = true;
		// }
		// else{
		// 	mainCamera.enabled = true;
		// 	mainCamera1.enabled = false;
		// }

		// this.transform.position = new Vector3(
		// 
		// );
		// if (ver > 0 && hor > 0)
		// {
		// 	lookDirection = new Vector3(hor, 0, ver);
		// }else {
		// 	lookDirection = new Vector3(Mathf.Abs(hor), 0, Mathf.Abs(ver));
		// }

		// lookDirection = new Vector3(hor, 0, ver);

	}

	private void Update () {
		ParticleSystemTimer -= Time.deltaTime;
		if (ParticleSystemTimer <= 0) {
			attackEffect.SetActive (false);
			ParticleSystemTimer = 2.0f;
		}

		if (health <= 0) {
			Time.timeScale = 0;
			Debug.Log ("GameOver");
		}

		// if (bIsBeingAttacked)
		// {
		// 	playerAnim.SetFloat("Speed", 1.0f);
		// }
	}

	void FixedUpdate () {
		touchInput ();
	}

	void OnCollisionEnter (Collision collision) {
		// animator.SetFloat("SpeedPercent", 0);
		// Debug.Log("Working");
		// if (collision.gameObject.tag != "terrain")
		// {
		// 	isOnCollision = true;
		// }
		if (collision.gameObject.tag == "Enemy") {
			// playerAnim.SetFloat ("Speed", 1.0f);
			bIsBeingAttacked = true;
		}
	}

	void OnCollisionExit (Collision collision) {
		// animator.SetFloat("SpeedPercent", 0.6f);
		// if (collision.gameObject.tag != "terrain")
		// {
		// 	isOnCollision = false;
		// }
		if (collision.gameObject.tag == "Enemy") {
			// playerAnim.SetFloat ("Speed", 1.0f);
			bIsBeingAttacked = false;
		}

	}

	void OnCollisionStay (Collision collision) {
		if (collision.gameObject.tag == "Enemy") {
			playerAnim.SetFloat ("Speed", 1.0f);
		}
		if ((int) Time.frameCount % 150 == 0) {
			// if (player) {
			// 	player.GetComponent<PlayerController> ().health -= damageAmount * Time.deltaTime;
			// 	Debug.Log (player.GetComponent<PlayerController> ().health);
			// }
			health -= collision.gameObject.GetComponent<EnemyController>().damageAmount*Time.deltaTime;
			Debug.Log(health);
		}
	}
}