using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EgitmenControl : MonoBehaviour {


    public Text gucText;
    public Text beceriText;
    public Text ceviklikText;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        gucText.text = GameControl.caracter.Guc.ToString();
        beceriText.text = GameControl.caracter.Beceri.ToString();
        ceviklikText.text = GameControl.caracter.Ceviklik.ToString();

    }


    public void gucArttir() {
        if (GameControl.caracter.Altin >= 10)
        {
            GameControl.caracter.Guc++;
            GameControl.caracter.Altin -= 10;
        }
    }
    public void beceriArttir()
    {
        if (GameControl.caracter.Altin>=10)
        {
            GameControl.caracter.Beceri++;
            GameControl.caracter.Altin -= 10;
        }
        

    }
    public void ceviklikArttir()
    {
        if (GameControl.caracter.Altin >= 10)
        {
            GameControl.caracter.Ceviklik++;
            GameControl.caracter.Altin -= 10;
        }
    }
}
