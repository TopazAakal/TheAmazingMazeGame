using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyX : MonoBehaviour
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
        this.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        if (this.transform.position.x > max)
        {
            speed = 5;
        }

        if (this.transform.position.x < min)
        {
            speed = -5;
        }
    }
}
