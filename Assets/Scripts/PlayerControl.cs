using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Animator animator;
    public Animator targe1;
    public Animator targe2;
    public Animator targe3;
    public Animator targe4;
    public Animator targe5;
    public GameObject cam;
    public GameObject gun;
    public GameObject raw;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject talim;
    public GameObject txt;
    public GameObject txtgun;
    public GameObject txtsandik;
    public GameObject txtkasa;
    public GameObject sandik;
    public GameObject panel;
    public float speed = 2f;
    private bool bol=true;
    public string talim4;

    void Start()
    {
        animator = GetComponent<Animator>();
        Scene targetScene = SceneManager.GetSceneByName(talim4);
        if (targetScene.isLoaded)
        {
            targe1 = target1.GetComponent<Animator>();
            targe2 = target2.GetComponent<Animator>();
            targe3 = target3.GetComponent<Animator>();
            targe4 = target4.GetComponent<Animator>();
            targe5 = target5.GetComponent<Animator>();
        }
        

    }
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        Scene targetScene = SceneManager.GetSceneByName(talim4);
        if (targetScene.isLoaded)
        {
            float text = Vector3.Distance(talim.transform.position, transform.position);
            if (text <= 6)
            {
                txt.SetActive(true);
            }
            else
            {
                txt.SetActive(false);
            }

            float mesafesandik = Vector3.Distance(sandik.transform.position, transform.position);
            if (mesafesandik <= 3 && sandik.active)
            {
                txtkasa.SetActive(false);
                txtsandik.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    bol = false;
                    txtkasa.SetActive(false);
                    panel.SetActive(true);
                }
                else
                    panel.SetActive(false);
            }
            else
            {
                txtsandik.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalking", false);

        if (animator.GetBool("isWalking") && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("isWalkingToR", true);
            transform.Translate(new Vector3(0, 0, speed * 2) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalkingToR", false);

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalkingBack", true);
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalkingBack", false);


        if (targetScene.isLoaded)
        {
            if (targe1.GetBool("isDie") && targe2.GetBool("isDie") && targe3.GetBool("isDie") && targe4.GetBool("isDie") && targe5.GetBool("isDie"))
            {
                txtgun.SetActive(false);
                sandik.SetActive(true);
            }
            if (!txtsandik.active && targe1.GetBool("isDie") && targe2.GetBool("isDie") && targe3.GetBool("isDie") && targe4.GetBool("isDie") && targe5.GetBool("isDie"))
            {
                if (bol)
                    txtkasa.SetActive(true);
            }
            if (Input.GetMouseButtonDown(0) && animator.GetBool("isHolding"))
            {
                animator.SetBool("isFire", true);
                RaycastHit hit;
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, Mathf.Infinity))
                {
                    GameObject hitObject = hit.collider.gameObject;
                    if (hitObject.name.Equals("target1"))
                    {
                        targe1.SetBool("isDie", true);
                    }
                    if (hitObject.name.Equals("target2"))
                    {
                        targe2.SetBool("isDie", true);
                    }
                    if (hitObject.name.Equals("target3"))
                    {
                        targe3.SetBool("isDie", true);
                    }
                    if (hitObject.name.Equals("target4"))
                    {
                        targe4.SetBool("isDie", true);
                    }
                    if (hitObject.name.Equals("target5"))
                    {
                        targe5.SetBool("isDie", true);
                    }


                    Debug.Log("Isabet edilen nesne: " + hitObject.name);
                }
            }
            else
                animator.SetBool("isFire", false);



            float distance = Vector3.Distance(gun.transform.position, transform.position);
            if (distance <= 3 && !sandik.active)
            {
                txtgun.SetActive(true);

                if (Input.GetKey(KeyCode.E))
                {
                    raw.SetActive(true);
                    print(gameObject.name);
                    animator.SetBool("isHolding", true);

                }
                else
                {
                    animator.SetBool("isHolding", false);
                    raw.SetActive(false);

                }
            }
            else
            {
                animator.SetBool("isHolding", false);
                txtgun.SetActive(false);
                raw.SetActive(false);
            }


        }
}

    
}
