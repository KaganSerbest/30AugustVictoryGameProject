using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saglik : MonoBehaviour
{
    public GameObject saglijKasasi;
    public GameObject bulmacaDefteri;
    public GameObject oyuncu;
    public GameObject sifreEkrani;
    public GameObject kapak1;
    public GameObject kapak2;
    public GameObject bulmacaEkrani;
    public GameObject sifre1;
    public GameObject sifre2;
    public GameObject sifre3;
    public GameObject sifre4;
    public GameObject sifre5;
    public GameObject sifre6;
    public GameObject sifre7;
    public GameObject sifre8;
    public GameObject sifre9;
    public GameObject sifre0;
    public GameObject sifreyiAl;
    public GameObject sifreyiBirak;
    public GameObject kasayaGeldin;
    public GameObject deftereGeldin;
    public GameObject kapi;
    public GameObject kapidanCikis;
    float sifresayac = 1;
    float bulamacasayac = 1;
    float kasasayac = 1;
    private bool sifreAcik = false;
    private string anaSifre = "";

    void Start()
    {
        
    }
  

    void Update()
    {
        float distanceKasa = Vector3.Distance(oyuncu.transform.position, saglijKasasi.transform.position);
        float distancedefter = Vector3.Distance(oyuncu.transform.position, bulmacaDefteri.transform.position);
        float distanceKapi = Vector3.Distance(oyuncu.transform.position, kapi.transform.position);

        if(distanceKapi <= 3)
        {
            kapidanCikis.SetActive(true);
        }
        else
        {
            kapidanCikis.SetActive(false);
        }

        if(distanceKapi <= 3 && Input.GetKeyDown(KeyCode.Y))
        { 
            SceneManager.LoadScene(0);
        }

        if (distanceKasa <= 4 && kasasayac == 1)
        {
            kasayaGeldin.SetActive(true);
        }
        else
        {
            kasayaGeldin.SetActive(false);
        }

        if (distancedefter <= 6 && bulamacasayac == 1)
        {
            deftereGeldin.SetActive(true);
        }
        else
        {
            deftereGeldin.SetActive(false);
        }

        if (distanceKasa <= 4 && Input.GetKeyDown(KeyCode.E))
        {
            kasasayac = 0;
            sifreEkrani.SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && distanceKasa<=4)
        {
            anaSifre += "1";
            sifre1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && distanceKasa <= 4)
        {
            anaSifre += "2";
            sifre2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && distanceKasa <= 4)
        {
            anaSifre += "3";
            sifre3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && distanceKasa <= 4)
        {
            anaSifre += "4";
            sifre4.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && distanceKasa <= 4)
        {
            anaSifre += "5";
            sifre5.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && distanceKasa <= 4)
        {
            anaSifre += "6";
            sifre6.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && distanceKasa <= 4)
        {
            anaSifre += "7";
            sifre7.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && distanceKasa <= 4)
        {
            anaSifre += "8";
            sifre8.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) && distanceKasa <= 4)
        {
            anaSifre += "9";
            sifre9.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0) && distanceKasa <= 4)
        {
            anaSifre += "0";
            sifre0.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Backspace) && distanceKasa <= 4)
        {
            sifre1.SetActive(false);
            sifre2.SetActive(false);
            sifre3.SetActive(false);
            sifre4.SetActive(false);
            sifre5.SetActive(false);
            sifre6.SetActive(false);
            sifre7.SetActive(false);
            sifre8.SetActive(false);
            sifre9.SetActive(false);
            sifre0.SetActive(false);
            anaSifre = "";
        }

        if(anaSifre == "8243" && sifresayac == 1)
        {
            sifreEkrani.SetActive(false);
            kapak1.SetActive(false);
            sifreAcik = true;
            sifreyiAl.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sifreEkrani.SetActive(false);
            bulmacaEkrani.SetActive(false);
        }

        if(distanceKasa >= 5)
        {
            sifreEkrani.SetActive(false);
        }

        if (distanceKasa <= 4 && Input.GetKeyDown(KeyCode.Space))
        {
            kapak1.SetActive(false);
        }

        if(distancedefter <= 6 && Input.GetKeyDown(KeyCode.E))
        {
            bulamacasayac = 0;
            bulmacaEkrani.SetActive(true);
            
        }

        if(distancedefter >= 7)
        {
            bulmacaEkrani.SetActive(false);
        }

        if (distanceKasa <= 4 && Input.GetKeyDown(KeyCode.X) && sifreAcik)
        {
            sifresayac = 0;
            sifreyiBirak.SetActive(true);
            sifreyiAl.SetActive(false);
        }

        if (distanceKasa <= 4 && Input.GetKeyDown(KeyCode.Z) && sifreAcik)
        {
            sifreyiBirak.SetActive(false);
            
        }






    }
}
