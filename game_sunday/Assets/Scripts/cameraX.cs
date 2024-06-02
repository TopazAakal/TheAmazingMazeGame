using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraX : MonoBehaviour
{
    float speed = 2f;
    float mouseX = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouseX = Input.GetAxis("Mouse X") * speed;
            Vector3 newRotation = transform.localEulerAngles;
            newRotation.y += mouseX;
            transform.localEulerAngles = newRotation;
        }
    }
}
