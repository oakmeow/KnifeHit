using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Knife : MonoBehaviour
{
    private Rigidbody rb;
    private bool onBoard;
    private GameController gc;

    // Config
    private float speed = 5f;

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
            //rb.detectCollisions = false; // ยกเลิก Detect การชน
            gc.SpawnKnife();
            gc.AddScore();
        }
        if (other.gameObject.tag == "Knife")
        {
            gc.PauseGame();
        }
    }
}
