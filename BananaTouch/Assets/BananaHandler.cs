using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaHandler : MonoBehaviour {

	public float totalBan;
	public float bps;
	public Text totalBanTxt;
	public Text bpsTxt;

	public float updateTime;
	float counter;

	public bool minimumUpdateTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (minimumUpdateTime)
			updateTime = Time.deltaTime;

		bpsTxt.text = bps + " Bananas/Second";
		totalBanTxt.text = totalBan.ToString ("F1") + " Bananas";

		if (counter < updateTime)
			counter += Time.deltaTime;
		else {
			totalBan += bps * updateTime;
			counter = 0;
		}
		
	}
}
