using UnityEngine;
using System.Collections;

public class tankmove : MonoBehaviour {
    public float speed, rot, drag, bulSpeed;
    public GameObject treads, bullet, barrel;
	public int timer;

	// Use this for initialization
	void Start () {
		timer = 0;
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
	void Update (){
		if (timer == 0) {
			AkSoundEngine.SetState ("Fire", "No_Fire");
			timer = 0; 	
		} else
			timer--;
		if(Input.GetButtonDown("Fire1")) {
			if(gameObject.GetComponent<mode>().tankMode == 1)
				AkSoundEngine.SetState ("Fire", "Fire_Light");
			else if(gameObject.GetComponent<mode>().tankMode == 2)
				AkSoundEngine.SetState ("Fire", "Fire_Med");
			else if(gameObject.GetComponent<mode>().tankMode == 3)
				AkSoundEngine.SetState ("Fire", "Fire_Heavy");
			timer = 5;
			GameObject newBullet = (GameObject) GameObject.Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
			newBullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0f,0f,0.00001f*bulSpeed));

		}
			
	}
}
