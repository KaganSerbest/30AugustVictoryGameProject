using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hangar2 : MonoBehaviour
{
    public GameObject truck;
    public GameObject txtruck;
    public GameObject gorev;
    public GameObject varil;
    public GameObject yukv1;
    public GameObject yukv2;
    public GameObject yukv3;
    public GameObject yukk1;
    public GameObject yukk2;
    public GameObject yukk3;
    public GameObject kutular;
    public GameObject playerv;
    public GameObject playerk;
    public GameObject panel;
    public GameObject sifre;
    public GameObject hangarKapisi;
    public GameObject hangarCikisYazisi;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float mesafetruck = Vector3.Distance(truck.transform.position, transform.position);
         bool oky = (yukv1.active && yukv2.active && yukv3.active && yukk1.active && yukk2.active && yukk3.active);
        if (oky && mesafetruck <= 10)
        {
            sifre.SetActive(true);
            gorev.SetActive(false);
            if (Input.GetKey(KeyCode.Space) ) 
            {
            panel.SetActive(true);
            }
            else
            {
                panel.SetActive(false);
            }

        }
        else
        {
            sifre.SetActive(false);
        }
        

        if (mesafetruck <= 10 && !gorev.active && !oky)
        {
            txtruck.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
                gorev.SetActive(true);
        }
        else if (mesafetruck <= 10 && gorev.active && !oky)
{
            if (Input.GetKeyDown(KeyCode.R) && playerv.active)
            {
                if(!yukv1.active&& !yukv2.active && !yukv3.active)
                {
                yukv1.SetActive(true);
                playerv.SetActive(false);

                }
                else if (yukv1.active && !yukv2.active && !yukv3.active)
                {
                    yukv2.SetActive(true);
                    playerv.SetActive(false);

                }
                else if (yukv1.active && yukv2.active && !yukv3.active)
                {
                    yukv3.SetActive(true);
                    playerv.SetActive(false);

                }

            }
            else if(Input.GetKeyDown(KeyCode.R) && playerk.active)
            {
                if (!yukk1.active && !yukk2.active && !yukk3.active)
                {
                    yukk1.SetActive(true);
                    playerk.SetActive(false);

                }
                else if (yukk1.active && !yukk2.active && !yukv3.active)
                {
                    yukk2.SetActive(true);
                    playerk.SetActive(false);

                }
                else if (yukk1.active && yukk2.active && !yukk3.active)
                {
                    yukk3.SetActive(true);
                    playerk.SetActive(false);

                }

            }
        }
        else
            txtruck.SetActive(false);

        float hangarMesafe = Vector3.Distance(transform.position, hangarKapisi.transform.position);
        if (hangarMesafe <= 20)
        {
            hangarCikisYazisi.SetActive(true);
        }
        else
        {
            hangarCikisYazisi.SetActive(false);
        }
        if (hangarMesafe <= 20 && Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(1);
        }





        float varilmesafe = Vector3.Distance(varil.transform.position, transform.position);
        if (varilmesafe <= 3)
        {
            
            if (Input.GetKeyDown(KeyCode.E) && !playerk.active && !playerv.active && gorev.active)
            {
                playerv.SetActive(!playerv.active);

            } 
            else if (Input.GetKeyDown(KeyCode.R) && playerv.active)
            {
                playerv.SetActive(!playerv.active);
            }
        }

        float kutumesafe = Vector3.Distance(kutular.transform.position, transform.position);
        if (kutumesafe <= 5)
        {
            
            if (Input.GetKeyDown(KeyCode.E) && !playerv.active && !playerk.active && gorev.active)
            {
                playerk.SetActive(!playerk.active);
            }
            else if (Input.GetKeyDown(KeyCode.R) && playerk.active)
            {
                playerk.SetActive(!playerk.active);
            }

        }


    }
}
