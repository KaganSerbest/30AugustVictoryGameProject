using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Animator animator;
    public GameObject cam;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
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

        
    }
}
