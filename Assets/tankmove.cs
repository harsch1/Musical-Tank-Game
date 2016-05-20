using UnityEngine;
using System.Collections;

public class tankmove : MonoBehaviour {
    public float speed, rot, drag;
    public GameObject treads;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetAxis("Vertical") != 0f) {
            gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, speed * Input.GetAxis("Vertical")), ForceMode2D.Force);
        }
        else {
            if (gameObject.GetComponent<Rigidbody2D>().velocity.y > 0f) {
                gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, drag * -1f), ForceMode2D.Force);
            }
            else if (gameObject.GetComponent<Rigidbody2D>().velocity.y < 0f) {
                gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, drag), ForceMode2D.Force);
            }

        }
        if (Input.GetAxis("Horizontal") != 0f) {
            if (Input.GetAxis("Horizontal") < 0f) {
                gameObject.GetComponent<Rigidbody2D>().MoveRotation(gameObject.GetComponent<Rigidbody2D>().rotation + rot);
            }
            else if (Input.GetAxis("Horizontal") > 0f) {
                gameObject.GetComponent<Rigidbody2D>().MoveRotation(gameObject.GetComponent<Rigidbody2D>().rotation - rot);
            }
        }
	}
}
