using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mode : MonoBehaviour {
    public int tankMode;
    public Image indic;
	// Use this for initialization
	void Start () {
		tankMode = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            tankMode = 1;
            indic.color = new Color(0f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            tankMode = 1;
			indic.color = new Color(1f, 0f, 0f);
			gameObject.GetComponent<shoot> ().bulSpeed = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            tankMode = 2;
			indic.color = new Color(0f, 1f, 0f);
			gameObject.GetComponent<shoot> ().bulSpeed = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            tankMode = 3;
            indic.color = new Color(0f, 0f, 1f);
			gameObject.GetComponent<shoot> ().bulSpeed = 2;
        }
    }
}
