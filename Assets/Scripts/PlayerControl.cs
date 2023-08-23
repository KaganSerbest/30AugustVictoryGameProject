using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    void Start()
    {
        animator = GetComponent<Animator>();
        targe1 = target1.GetComponent<Animator>();
        targe2 = target2.GetComponent<Animator>();
        targe3 = target3.GetComponent<Animator>();
        targe4 = target4.GetComponent<Animator>();
        targe5 = target5.GetComponent<Animator>();
    }
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalking", false);

        if (animator.GetBool("isWalking") && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("isWalkingToR", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalkingToR", false);

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalkingBack", true);
            transform.Translate(new Vector3(0, 0, -2f) * Time.deltaTime);
        }
        else
            animator.SetBool("isWalkingBack", false);

        if (Input.GetMouseButtonDown(0)&& animator.GetBool("isHolding"))
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
        if (distance <= 3)
        {

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
        }

        

}
