using UnityEngine;
using System.Collections;

public class target : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter (Collider other) {
        Debug.Log("Collision from " + other.tag);
        if(other.tag == "Bullet") {
            Object.Destroy(other.gameObject);
            Object.Destroy(gameObject);
        }
    }
}
