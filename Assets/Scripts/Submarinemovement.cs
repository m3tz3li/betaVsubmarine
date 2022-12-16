using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Submarinemovement : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public Text lives;
    public Rigidbody rb;
    public float forceV = 1.5f;
    public float WSforce;
    public int Health = 3;
    public int maxHearts;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        lives.text = Health.ToString();
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * WSforce);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * WSforce);
        }
        
        if(transform.position.y > 8.5)
        {
            transform.position = new Vector3(transform.position.x, 8.5f, transform.position.z);
        }
        if (transform.position.y < -7)
        {
            transform.position = new Vector3(transform.position.x, -7, transform.position.z);
        }

        if(Health > maxHearts)
        {
            Health = maxHearts;
        }

        if(Health <= 0)
        {
            SceneManager.LoadScene("Main Menu");
        }

        if(Health >= 1)
        {
            heart1.SetActive(true);
        }
        else
        {
            heart1.SetActive(false);
        }
        if (Health >= 2)
        {
            heart2.SetActive(true);
        }
        else
        {
            heart2.SetActive(false);
        }
        if (Health >= 3)
        {
            heart3.SetActive(true);
        }
        else
        {
            heart3.SetActive(false);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * forceV, ForceMode.Acceleration);
    }

    public void Heal()
    {
        Health = Health + 1;
    }

    public void Damage()
    {
        Health = Health - 1;
    }
}
