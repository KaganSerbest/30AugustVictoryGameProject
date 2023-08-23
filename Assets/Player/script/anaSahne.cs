using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaSahne : MonoBehaviour
{
    public GameObject talimLevha;
    public GameObject hangarLevha;
    public GameObject ofisLevha;
    public GameObject kislaLevha;
    public GameObject saglikLevha;
    public GameObject oyuncu;
    public GameObject sifreYanlisUyarisi;
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
    public GameObject kapidanGirofis;
    public GameObject kapidanGirhangar;
    public GameObject kapidanGirkisla;
    public GameObject kapidanGirsaglik;
    public GameObject kapidanGirtalim;
    private string anaSifre = "";
    void Start()
    {
        
    }

    
    void Update()
    {
        float mesafeTalim = Vector3.Distance(oyuncu.transform.position, talimLevha.transform.position);
        float mesafeHangar = Vector3.Distance(oyuncu.transform.position, hangarLevha.transform.position);
        float mesafeSaglik = Vector3.Distance(oyuncu.transform.position, saglikLevha.transform.position);
        float mesafeOfis = Vector3.Distance(oyuncu.transform.position, ofisLevha.transform.position);
        float mesafeKisla = Vector3.Distance(oyuncu.transform.position, kislaLevha.transform.position);

        if (mesafeHangar <= 10)
        {
            kapidanGirhangar.SetActive(true);
        }
        else
        {
            kapidanGirhangar.SetActive(false);
        }
        if (mesafeKisla <= 10)
        {
            kapidanGirkisla.SetActive(true);
        }
        else
        {
            kapidanGirkisla.SetActive(false);
        }
        if (mesafeSaglik <= 10)
        {
            kapidanGirsaglik.SetActive(true);
        }
        else
        {
            kapidanGirsaglik.SetActive(false);
        }
        if (mesafeOfis <= 10)
        {
            kapidanGirofis.SetActive(true);
        }
        else
        {
            kapidanGirofis.SetActive(false);
        }
        if (mesafeTalim <= 10)
        {
            kapidanGirtalim.SetActive(true);
        }
        else
        {
            kapidanGirtalim.SetActive(false);
        }

        if (mesafeHangar <= 10 && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(1);
        }

        if (mesafeTalim <= 10 && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(3);
        }

        if (mesafeSaglik <= 10 && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(2);
        }

        if (mesafeKisla <= 10 && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(4);
        }

        if (mesafeOfis <= 10 && Input.GetKeyDown(KeyCode.Y))
        {
            sifreYanlisUyarisi.SetActive(true);
        }

        if(mesafeOfis >= 11)
        {
            sifreYanlisUyarisi.SetActive(false);
        }
       
        if (Input.GetKeyDown(KeyCode.Alpha1) && mesafeOfis <= 10)
        {
            anaSifre += "1";
            sifre1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && mesafeOfis <= 10)
        {
            anaSifre += "2";
            sifre2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && mesafeOfis <= 10)
        {
            anaSifre += "3";
            sifre3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && mesafeOfis <= 10)
        {
            anaSifre += "4";
            sifre4.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && mesafeOfis <= 10)
        {
            anaSifre += "5";
            sifre5.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && mesafeOfis <= 10)
        {
            anaSifre += "6";
            sifre6.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && mesafeOfis <= 10)
        {
            anaSifre += "7";
            sifre7.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && mesafeOfis <= 10)
        {
            anaSifre += "8";
            sifre8.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) && mesafeOfis <= 10)
        {
            anaSifre += "9";
            sifre9.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0) && mesafeOfis <= 10)
        {
            anaSifre += "0";
            sifre0.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Backspace) && mesafeOfis <= 10)
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sifreYanlisUyarisi.SetActive(false);
        }

        if (anaSifre == "1071")
        {
            SceneManager.LoadScene(5);
        }


        

    }
}
