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
        uyku.SetActive(false);
        yeniGorev.SetActive(true);
    }
    public void bilmiyorumButonu()
    {
        SceneManager.LoadScene(5);
    }
    
}
