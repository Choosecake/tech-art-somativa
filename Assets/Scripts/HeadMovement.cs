using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour
{
    [SerializeField] private float sensitivity = 100f;
    private float mouseX, mouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        mouseX += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        
        // locks y camera rotation to limited range
        mouseY = Mathf.Clamp(mouseY, -90, 90);
        
        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0); 
    }
}
