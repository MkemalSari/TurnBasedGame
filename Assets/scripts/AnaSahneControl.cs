using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaSahneControl : MonoBehaviour {

    
    
	void Start () {
        
      
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    

    public void sahneAc(string sahneAdi) {
        SceneManager.LoadScene(sahneAdi, LoadSceneMode.Single);
    }
}
