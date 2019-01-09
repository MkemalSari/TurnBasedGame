using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketControl : MonoBehaviour {


    public GameObject itemlar;
    Button[] buttonList;

	void Start () {
       buttonList= itemlar.GetComponentsInChildren<Button>();
       
        buttonList[0].onClick.AddListener(ItemEkle);
        buttonList[1].onClick.AddListener(ItemEkle1);
        buttonList[2].onClick.AddListener(ItemEkle2);
        buttonList[3].onClick.AddListener(ItemEkle3);
        buttonList[4].onClick.AddListener(ItemEkle4);
        buttonList[5].onClick.AddListener(ItemEkle5);
        buttonList[6].onClick.AddListener(ItemEkle6);
        buttonList[7].onClick.AddListener(ItemEkle7);
        buttonList[8].onClick.AddListener(ItemEkle8);




    }
    

    void ItemEkle()
    {
        if (GameControl.caracter.Altin >= GameControl.items[0].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[0].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[0].Ad;
           
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[0].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[0].Guc;
        }
    }

    void ItemEkle1()
    {
        if (GameControl.caracter.Altin >= GameControl.items[1].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[1].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[1].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[1].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[1].Guc;
        }



    }
    void ItemEkle2()
    {
        if (GameControl.caracter.Altin >= GameControl.items[2].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[2].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[2].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[2].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[2].Guc;
        }



    }
    void ItemEkle3()
    {
        if (GameControl.caracter.Altin >= GameControl.items[3].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[3].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[3].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[3].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[3].Guc;
        }



    }
    void ItemEkle4()
    {
        if (GameControl.caracter.Altin >= GameControl.items[4].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[4].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[4].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[4].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[4].Guc;
        }



    }
    void ItemEkle5()
    {
        if (GameControl.caracter.Altin >= GameControl.items[5].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[5].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[5].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[5].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[5].Guc;
        }



    }
    void ItemEkle6()
    {
        if (GameControl.caracter.Altin >= GameControl.items[6].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[6].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[6].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[6].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[6].Guc;
        }



    }
    void ItemEkle7()
    {
        if (GameControl.caracter.Altin >= GameControl.items[7].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[7].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[7].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[7].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[7].Guc;
        }



    }
    void ItemEkle8()
    {
        if (GameControl.caracter.Altin >= GameControl.items[8].Deger)
        {
            GameControl.caracter.Altin -= GameControl.items[8].Deger;
            GameControl.caracter.Silah.Ad = GameControl.items[8].Ad;
            GameControl.caracter.Guc -= GameControl.caracter.Silah.Guc;
            GameControl.caracter.Guc += GameControl.items[8].Guc;
            GameControl.caracter.Silah.Guc = GameControl.items[8].Guc;
        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
