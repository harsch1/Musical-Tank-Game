using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
    public static float CDRED, CDGREEN, CDBLUE;

    public float bulSpeed, shotTimer;
    public GameObject bullet, barrel;
	public int timer;

    // Use this for initialization
    void Start () {
        timer = 0;

    }

    // Update is called once per frame

    void Update() {
        if (timer == 0) {
            AkSoundEngine.SetState("Fire", "No_Fire");
        }
        else
            timer--;
        if (Input.GetButtonDown("Fire1")) {
            if (gameObject.GetComponent<mode>().tankMode == 1)
                AkSoundEngine.SetState("Fire", "Fire_Light");
            else if (gameObject.GetComponent<mode>().tankMode == 2)
                AkSoundEngine.SetState("Fire", "Fire_Med");
            else if (gameObject.GetComponent<mode>().tankMode == 3)
                AkSoundEngine.SetState("Fire", "Fire_Heavy");
            timer = 5;
            GameObject newBullet = (GameObject)GameObject.Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0f, 0f, 0.00001f * bulSpeed));

        }

    }
}
