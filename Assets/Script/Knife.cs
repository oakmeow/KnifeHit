using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private bool onBoard;
    private GameController gc;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gc = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && !onBoard)
        {
            rb.velocity = new Vector3(0f, speed, 0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Board")
        {
            gameObject.transform.SetParent(other.transform);
            rb.velocity = Vector3.zero;
            onBoard = true;
            gc.SpawnKnife();
            gc.AddScore();
        }
        if (other.gameObject.tag == "Knife")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
