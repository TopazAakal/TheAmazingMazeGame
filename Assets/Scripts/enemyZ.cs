using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyZ : MonoBehaviour
{
    public int speed = 5;
    public int min;
    public int max;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if (transform.position.z > max)
        {
            transform.Rotate(0, 180, 0);
        }

        if (transform.position.z < min) 
        {
            transform.Rotate(0, 180, 0);

        }

    }
}
