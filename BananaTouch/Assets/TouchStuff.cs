using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchStuff : MonoBehaviour {

	int i;
	public int maxFinger;
	int fingerCount;
	public Text score; 

	public GameObject cut;



	// Use this for initialization
	Vector3 worldPos;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began && fingerCount < maxFinger) {
				i++;
				this.GetComponent<Animator> ().SetBool ("Tapped", true);
				worldPos = Camera.main.ScreenToWorldPoint (touch.position);
				worldPos.z = 0;

				Instantiate (cut,worldPos,Quaternion.Euler(0,0,Random.Range(80,100)));
			}
			fingerCount++;
		}
		score.text = i.ToString ();
		
	}
	public void TappedFalse(){
		this.GetComponent<Animator> ().SetBool ("Tapped", false);
	
	}
}
