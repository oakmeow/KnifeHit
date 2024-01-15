using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{
    // Config
    private float speed = 60f;
    private float destroy_time = 3.5f;

    private void Start()
    {
        Destroy(gameObject, destroy_time);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
