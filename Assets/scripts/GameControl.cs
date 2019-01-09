using Assets.scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public GameObject panel;
    public void PanelAc()
    {
        VeriDoldur();
        panel.SetActive(true);

    }


    public void SahneGecis(string sahneAdi) {

        
        SceneManager.LoadScene(sahneAdi, LoadSceneMode.Single);
    }
  public static  List<Item> items = new List<Item>();
    public static List<Moster> mosters = new List<Moster>();
    public static Caracter caracter = new Caracter();
    public static List<Dialog> dialogs = new List<Dialog>();
    public InputField ad;
    public RawImage[] itemResimler;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
    }

   

    // Update is called once per frame
    void Update () {
		
	}

    public void VeriDoldur() {
        //İtem Control


        for (int i = 1; i <= 10; i++)
        {
            Item item = new Item();

            item.Ad = "İtem Adi " + i;
            item.Resim = itemResimler[i-1];
            item.Guc = i;
            item.Deger = (i)*10;
            items.Add(item);
        }
        Item copitem = new Item();
        copitem.Ad = "deynek";
        copitem.Deger = 0;
        copitem.Guc = 0;
        items.Add(copitem);

        caracter.Ad = ad.text;
        caracter.Altin = 100;
        caracter.Silah = items[10];
        caracter.Zırh = null;
        caracter.Beceri = 1;
        caracter.Can = 100;
        caracter.Ceviklik = 1;
        caracter.Deneyim = 0;
        caracter.Guc = 1;

        
        caracter.Seviye = 1;
        caracter.Susama = 100;
        caracter.Aclik = 100;
        

       


       
      
            Moster moster = new Moster();

            moster.Ad = "Movia ";
            moster.Beceri =1;
            moster.Ceviklik = 1;
            moster.Guc = 1;
            moster.Can = 100;
            moster.Seviye = 1;
            moster.Silah = items[1];
            moster.Zırh = items[5];

            mosters.Add(moster);

        Moster moster1 = new Moster();

        moster1.Ad = "Goblin ";
        moster1.Beceri = 3;
        moster1.Ceviklik = 3;
        moster1.Guc = 3;
        moster1.Can = 100;
        moster1.Seviye = 3;
        moster1.Silah = items[1];
        moster1.Zırh = items[5];

        mosters.Add(moster1);
        Moster moster2 = new Moster();

        moster2.Ad = "Sentor ";
        moster2.Beceri = 5;
        moster2.Ceviklik = 5;
        moster2.Guc = 5;
        moster2.Can = 100;
        moster2.Seviye = 5;
        moster2.Silah = items[1];
        moster2.Zırh = items[5];

        mosters.Add(moster2);

        Moster moster3 = new Moster();

        moster3.Ad = "Dragon ";
        moster3.Beceri = 20;
        moster3.Ceviklik = 20;
        moster3.Guc = 20;
        moster3.Can = 100;
        moster3.Seviye = 20;
        moster3.Silah = items[1];
        moster3.Zırh = items[5];

        mosters.Add(moster3);



        //1.Benim dialog
        Dialog benimDialog = new Dialog();
        benimDialog.Name = "Benim";
        string[] dizi = new string[3] { "Merhaba", "Benim için nelerin var?", "Hımm Çok iyi hemen bakmalıyım?" };
        benimDialog.KonusmaMetni = dizi;
        dialogs.Add(benimDialog);
        //2.Market dialog
        Dialog merketDialog = new Dialog();
        merketDialog.Name = "Market";
        string[] dizi1 = new string[3] { "Merhaba", "Yemekler Silahlar Zıhlar?", "Tabi Buyurun?" };
        merketDialog.KonusmaMetni = dizi1;
        dialogs.Add(merketDialog);
        //3.Benim dialog
        Dialog benimDialog_muhtar = new Dialog();
        benimDialog_muhtar.Name = "Benim_muhtar";
        string[] dizi2 = new string[3] { "Merhaba", "Ben buralarda yeniyim Bana biraz köyden bahsermisin ?", "Evet ??" };
        benimDialog_muhtar.KonusmaMetni = dizi2;
        dialogs.Add(benimDialog_muhtar);

        Dialog muhtarDialog = new Dialog();
        muhtarDialog.Name = "Muhtar";
        string[] dizi3 = new string[3] { "Merhaba", "Hoşgeldin. Yeni hayaller kurman için En uygun Yer Vee..", "Ticaretin evrenimizdeki merkez noktası." };
        muhtarDialog.KonusmaMetni = dizi3;
        dialogs.Add(muhtarDialog);

        Dialog benimDialog_Egitmen = new Dialog();
        benimDialog_Egitmen.Name = "Benim_Egitmen";
        string[] dizi4 = new string[3] { "Merhaba", "Senin bu köydeki en iyi eğitmen olduğun söylendi. ?", "Bana neler yapabileceğini göster" };
        benimDialog_Egitmen.KonusmaMetni = dizi4;
        dialogs.Add(benimDialog_Egitmen);

        Dialog egitmenDialog = new Dialog();
        egitmenDialog.Name = "Egitmen";
        string[] dizi5 = new string[3] { "Merhaba", "Evet İstersen senide makul bir fiyat karşılığında eğitebilirim", "Hadi başlayalım o zaman" };
        egitmenDialog.KonusmaMetni = dizi5;
        dialogs.Add(egitmenDialog);


    }


}
