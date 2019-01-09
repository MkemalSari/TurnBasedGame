using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombatControl : MonoBehaviour {

    bool battle =false;
    bool playerSecim = false;
    public Button saldiriButton;
    public Button savunmaButton;
    public GameObject ShieldHero;
    public GameObject ShieldMoster;
    public GameObject heroAnim;
    public GameObject mosterAnim;
    Animator hero;
    Animator moster;
    public Slider heroCanSlider;
    public Slider mosterCanSlider;
    public Text heroGuc;
    public Text heroBeceriklik;
    public Text heroCeviklik;
    public Text mosterGuc;
    public Text mosterBeceriklik;
    public Text mosterCeviklik;
    public Text HeroAd;
    public Text MosterAd;
    public int MosterSecim;


    // Use this for initialization
    void Start () {
        saldiriButton.onClick.AddListener(PlayerAttack);
        savunmaButton.onClick.AddListener(PlayerDefance);
        hero = heroAnim.GetComponent<Animator>();
        moster = mosterAnim.GetComponent<Animator>();

        heroGuc.text = GameControl.caracter.Guc.ToString();
        heroBeceriklik.text = GameControl.caracter.Beceri.ToString();
        heroCeviklik.text = GameControl.caracter.Ceviklik.ToString();
        mosterGuc.text = GameControl.mosters[MosterSecim].Guc.ToString();
        mosterBeceriklik.text = GameControl.mosters[MosterSecim].Beceri.ToString();
        mosterCeviklik.text = GameControl.mosters[MosterSecim].Ceviklik.ToString();
        HeroAd.text = GameControl.caracter.Ad;
        MosterAd.text = GameControl.mosters[MosterSecim].Ad;

    }

    private void FixedUpdate()
    {
        

        heroCanSlider.value =   GameControl.caracter.Can;
        mosterCanSlider.value =  GameControl.mosters[MosterSecim].Can;
    }
    // Update is called once per frame
    void Update () {



    }
   

    public void PlayerSecimSaldiri() {
        ShieldHero.SetActive(false);

        playerSecim = true;

    }
    public void PlayerSecimSavunma()
    {
       

        playerSecim = false;

    }

    public void PlayerAttack()
    {
        ShieldHero.SetActive(false);
        hero.Play("heroAtackAnim",-1,0f);
        GameControl.mosters[MosterSecim].Can -= GameControl.caracter.Guc;

        if (GameControl.mosters[MosterSecim].Can<=0)
        {
            moster.Play("DeathAnim", -1, 0f);
            GameControl.caracter.Altin += 10;
            GameControl.caracter.Deneyim += 30;
            if (GameControl.caracter.Deneyim>=100)
            {
                
                GameControl.caracter.Seviye += 1;
                GameControl.caracter.Deneyim = 100-GameControl.caracter.Deneyim;
            }
            GameControl.mosters[MosterSecim].Can = 100;
            SceneManager.LoadScene("AnaSahne", LoadSceneMode.Single);
        }
        Invoke("Enemyattack", 1f);


    }

    public void PlayerDefance()
    {
        ShieldHero.SetActive(true);
        moster.Play("mosterAtackAnim", -1, 0f);


    }
    public void EnemyChoose()
    {


    }
    public void Enemyattack()
    {
        GameControl.caracter.Can -= GameControl.mosters[MosterSecim].Guc;

        if (GameControl.caracter.Can<=0)
        {
            SceneManager.LoadScene("GirisSahne", LoadSceneMode.Single);
        }
        ShieldMoster.SetActive(false);
        moster.Play("mosterAtackAnim", -1, 0f);

    }
    public void EnemyDefance()
    {
        ShieldMoster.SetActive(true);
    }

}

