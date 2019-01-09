
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SehirControl : MonoBehaviour {

    
    public Text isim;
    public GameObject panelKapanacakMarket;
    public GameObject panelAcilacakMarket;
    public GameObject panelKapanacakMuhtar;
    public GameObject panelKapanacakEgitmen;
    public GameObject panelAcilacakEgitmen;
    public GameObject panelKapanacakKumar;
 

    public GameObject[] items;

    public Button marketButton;
    public Text benimText;
    public Text marketText;

    public Button muhtarButton;
    public Text benimTextMuhtar;
    public Text muhtarText;

    public Button EgitmenbButton;
    public Text benimTextEgitmen;
    public Text EgitmenText;

    public Button kumarButton;
    public InputField kumarField;
    public Text kumarSonuc;
    int sayac = 0;
    void Start () {

        marketButton.onClick.AddListener(KonusMarket);
        muhtarButton.onClick.AddListener(KonusMuhtar);
        EgitmenbButton.onClick.AddListener(KonusEgitmen);
        kumarButton.onClick.AddListener(KumarBtn);

        for (int i = 0; i < items.Length; i++)
        {
            items[i].GetComponentsInChildren<Text>()[0].text = GameControl.items[i].Ad;
            items[i].GetComponentInChildren<RawImage>().texture = GameControl.items[i].Resim.texture;
            items[i].GetComponentsInChildren<Text>()[1].text = "Güç : " +GameControl.items[i].Guc.ToString();
            items[i].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "Satıl Al : " + GameControl.items[i].Deger.ToString();

        }


        isim.text = GameControl.caracter.Ad;
	}
    void KonusMarket()
    {
        if (sayac==0)
        {
            benimText.text = GameControl.dialogs[0].KonusmaMetni[0];
        }
        if (sayac == 1)
        {
            marketText.text = GameControl.dialogs[1].KonusmaMetni[0];
        }
        if (sayac == 2)
        {
            benimText.text = GameControl.dialogs[0].KonusmaMetni[1];
        }
        if (sayac == 3)
        {
            marketText.text = GameControl.dialogs[1].KonusmaMetni[1];
        }
        if (sayac == 4)
        {
            benimText.text = GameControl.dialogs[0].KonusmaMetni[2];
        }
        if (sayac == 5)
        {
            marketText.text = GameControl.dialogs[1].KonusmaMetni[2];
        }
        sayac++;
        if (sayac==7)
        {

            panelKapat(panelKapanacakMarket);
            panelAc(panelAcilacakMarket);
            sayac = 0;
            benimText.text = "";
            marketText.text = "";
        }
       


    }
    void KonusMuhtar()
    {
        if (sayac == 0)
        {
            benimTextMuhtar.text = GameControl.dialogs[2].KonusmaMetni[0];
        }
        if (sayac == 1)
        {
            muhtarText.text = GameControl.dialogs[3].KonusmaMetni[0];
        }
        if (sayac == 2)
        {
            benimTextMuhtar.text = GameControl.dialogs[2].KonusmaMetni[1];
        }
        if (sayac == 3)
        {
            muhtarText.text = GameControl.dialogs[3].KonusmaMetni[1];
        }
        if (sayac == 4)
        {
            benimTextMuhtar.text = GameControl.dialogs[2].KonusmaMetni[2];
        }
        if (sayac == 5)
        {
            muhtarText.text = GameControl.dialogs[3].KonusmaMetni[2];
        }
        sayac++;
        if (sayac == 7)
        {

            panelKapat(panelKapanacakMuhtar);
            
            sayac = 0;
            benimText.text = "";
            marketText.text = "";
        }



    }
    void KonusEgitmen()
    {
        if (sayac == 0)
        {
            benimTextEgitmen.text = GameControl.dialogs[4].KonusmaMetni[0];
        }
        if (sayac == 1)
        {
            EgitmenText.text = GameControl.dialogs[5].KonusmaMetni[0];
        }
        if (sayac == 2)
        {
            benimTextEgitmen.text = GameControl.dialogs[4].KonusmaMetni[1];
        }
        if (sayac == 3)
        {
            EgitmenText.text = GameControl.dialogs[5].KonusmaMetni[1];
        }
        if (sayac == 4)
        {
            benimTextEgitmen.text = GameControl.dialogs[4].KonusmaMetni[2];
        }
        if (sayac == 5)
        {
            EgitmenText.text = GameControl.dialogs[5].KonusmaMetni[2];
        }
        sayac++;
        if (sayac == 7)
        {

            panelKapat(panelKapanacakEgitmen);
            panelAc(panelAcilacakEgitmen);

            sayac = 0;
            benimText.text = "";
            marketText.text = "";
        }



    }

    // Update is called once per frame
    void Update () {
		
	}

    public void panelKapat(GameObject obje) {
        obje.SetActive(false);

    }
    public void panelAc(GameObject obje)
    {
        obje.SetActive(true);

    }
    public void sahneAc()
    {
        SceneManager.LoadScene("AnaSahne", LoadSceneMode.Single);

    }
    public bool ZarAt()
    {

        int zar = Random.Range(1, 6);
        if (zar > 3)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public void KonrolluOyna(int para, int oynanılacakpara)
    {
        if (para < oynanılacakpara)
        {
            //yetersiz para
        }
        else
        {
            int p = KumarOyna(oynanılacakpara);//geriye kazanıp kazanılmıycak parayı döndürüyor direk mevcut paraya eklenicek.
            if (p < 0)
            {
                kumarSonuc.text = "Kaybettin";
                GameControl.caracter.Altin += p;
                //kaybettin.
                //mevcut para ile p yi topla
            }
            else
            {
                kumarSonuc.text = "Kazandın";
                GameControl.caracter.Altin += p;
                //kazandın
                //mevcut para ile p yi topla
            }
        }

    }
    public int KumarOyna(int paraMiktar)
    {
        if (ZarAt())
        {
            return paraMiktar;
        }
        else
        {
            return -paraMiktar;
        }
    }
    public void KumarBtn() {
        KonrolluOyna(GameControl.caracter.Altin, int.Parse(kumarField.text));

    }


}
