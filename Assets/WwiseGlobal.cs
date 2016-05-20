using UnityEngine;
using System.Collections;

public class WwiseGlobal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		AkSoundEngine.PostEvent ("SceneStart", this.gameObject);
		AkSoundEngine.SetState ("Fire", "No_Fire");
		AkSoundEngine.SetState ("Heavy_Weapon_Level", "Heavylvl1");
		AkSoundEngine.SetState ("Medium_Weapon_Level", "Medlvl1");
		AkSoundEngine.SetState ("Light_Weapon_Level", "Lightlvl1");	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
