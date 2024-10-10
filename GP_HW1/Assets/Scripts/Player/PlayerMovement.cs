using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    [SerializeField]
    float rotationSpeed = 1;

    void Start()
    {
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(0, 0, Time.deltaTime * speed); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0, 0, -Time.deltaTime * speed); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-Time.deltaTime * speed, 0, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(Time.deltaTime * speed, 0, 0); }

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed, 0);
    }
}
