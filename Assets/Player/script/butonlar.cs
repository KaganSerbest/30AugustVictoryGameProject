using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butonlar : MonoBehaviour
{

    public GameObject yeniGorev;
    public GameObject uyku;
    public void biliyorumButonu()
    {
        print("Buton1");
        uyku.SetActive(false);
        yeniGorev.SetActive(true);
    }
    public void bilmiyorumButonu()
    {
        print("buton2");
        SceneManager.LoadScene(5);
    }

    public void OnEndEditText(string metinseldeger)
    {
        print(metinseldeger);
    }
    
}
