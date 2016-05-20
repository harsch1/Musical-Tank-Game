using UnityEngine;
using System.Collections;

public class reticle : MonoBehaviour {
    public GameObject top;
    public Camera cam;
    public float mouse;

	// Use this for initialization
	void Start () { 
        //Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        mouse = Input.GetAxis("MouseMove");
        if (Input.GetAxis("MouseMove") != 0 && (Mathf.Abs(Input.GetAxis("AimX")) + Mathf.Abs(Input.GetAxis("AimY")) < 1.5f)){
            gameObject.transform.position = cam.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 5f);
        }
        else if(Mathf.Abs(Input.GetAxis("AimX")) + Mathf.Abs(Input.GetAxis("AimY")) > 0.3f){
            float x = Input.GetAxis("AimX");
            float y = Input.GetAxis("AimY");
            Vector2 angle = new Vector2(x, y);
            angle.Normalize();
            gameObject.transform.position = top.transform.position + (Vector3) (3f*angle);
        }
        top.transform.LookAt(gameObject.transform);
        top.transform.localEulerAngles = new Vector3(0f, top.transform.localEulerAngles.y, 0f);
    }
}
