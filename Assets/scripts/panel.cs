using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel : MonoBehaviour {

    public Text ad;
	void Start () {
        ad.text = GameControl.caracter.Ad;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
