using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public float mouseSens = 1000f;
    Transform player;
    float xRotation;
    void Start()
    {
       
        player = transform.parent;
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        player.Rotate(Vector3.up, mouseX);
        xRotation = -mouseY;
        xRotation = Mathf.Clamp(xRotation, -75, 75);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
