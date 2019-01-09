using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karvas : MonoBehaviour {

    public Text altinText;
    public Text canText;
    void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        altinText.text = GameControl.caracter.Altin.ToString();
        canText.text = GameControl.caracter.Seviye.ToString();
    }
}
