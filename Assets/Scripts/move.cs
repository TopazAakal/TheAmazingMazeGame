using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour
{

    public int speed = 5;
    public int jump = 5;
    public Rigidbody rb;
    public Text score;
    public int points=0;
    public Text playerName;
    public AudioSource audio1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "ball")
        {
            Destroy(other.gameObject);
            points++;
            playerName.text = "Name: " + startGame.name;
            score.text = "Score: " + points;
            audio1.Play();
            if (points == 5) {
                SceneManager.LoadScene("win");
            }
        }
        if (other.name == "enemy")
        {
            SceneManager.LoadScene("lose");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        playerName.text = "Name: " + startGame.name;
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

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 5)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        }
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(-2.85f,10,-24.39f);
        }

    }
}
