using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yaklasma : MonoBehaviour
{
    public GameObject player;
    public GameObject noodle1;
    public GameObject noodle2;
    public GameObject noodle3;
    public GameObject noodle4;
    public GameObject noodle6;
    public GameObject noodle7;
    public GameObject noodle8;
    public GameObject YeTusu;
    public GameObject UyuTusu1;
    public GameObject Uyku;
    public GameObject textSifre;
    public GameObject buton1;
    public GameObject buton2;
    public GameObject textUyan;
    public GameObject image;
    public GameObject Yatak;
    public GameObject yeniGorev;
    float noodleSayaci = 0;
    float uyusayaci = 1;
    float uykusayaci = 1;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance1 = Vector3.Distance(player.transform.position, noodle1.transform.position);
        if (distance1 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn1");
            noodle1.SetActive(false);
            noodleSayaci += 1;

            
        }
        float distance2 = Vector3.Distance(player.transform.position, noodle2.transform.position);
        if (distance2 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn2");
            noodle2.SetActive(false);
            noodleSayaci += 1;

        }
        float distance3 = Vector3.Distance(player.transform.position, noodle3.transform.position);
        if (distance3 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn3");
            noodle3.SetActive(false);
            noodleSayaci += 1;

        }
        float distance4 = Vector3.Distance(player.transform.position, noodle4.transform.position);
        if (distance4 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn4");
            noodle4.SetActive(false);
            noodleSayaci += 1;

        }
       
        float distance6 = Vector3.Distance(player.transform.position, noodle6.transform.position);
        if (distance6 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn6");
            noodle6.SetActive(false);
            noodleSayaci += 1;

        }
        float distance7 = Vector3.Distance(player.transform.position, noodle7.transform.position);
        if (distance7 <= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn7");
            noodle7.SetActive(false);
            noodleSayaci += 1;

        }
        float distance8 = Vector3.Distance(player.transform.position, noodle8.transform.position);
        if (distance8<= 7 && Input.GetKeyDown(KeyCode.E))
        {
            print("Yaklaþtýn8");
            noodle8.SetActive(false);
            noodleSayaci += 1;

        }

        if(noodleSayaci == 1 && uyusayaci == 1)
        {
            YeTusu.SetActive(false);
            UyuTusu1.SetActive(true);
            
        }

        float yatakMesafe = Vector3.Distance(player.transform.position, Yatak.transform.position);
        if (yatakMesafe <= 4 && Input.GetKeyDown(KeyCode.Space))
        {
            uyusayaci = 0;
            Uyku.SetActive(true);
            UyuTusu1.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {

            print("çalýþtý");
            textUyan.SetActive(false);
            textSifre.SetActive(true);
            buton1.SetActive(true);
            buton2.SetActive(true);
            print("çalýtý1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Buton1");
            Uyku.SetActive(false);
            yeniGorev.SetActive(true);
            SceneManager.LoadScene(1);
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("buton2");
            SceneManager.LoadScene(5);
            
        }










    }
}
