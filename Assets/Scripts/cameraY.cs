using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class cameraY : MonoBehaviour
{
    float speed = 2f;
    float mouseY = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouseY = Input.GetAxis("Mouse Y") * speed;
            Vector3 newRotation = transform.localEulerAngles;
            newRotation.x -= mouseY;
            transform.localEulerAngles = newRotation;
        }
    }
}
