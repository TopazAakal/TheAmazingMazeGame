using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int speed = 5;
    public int jump = 10;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "ball")
        {
            Destroy(other.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.Space) && transform.position.y < 1)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(0,10,0);
        }

    }
}
