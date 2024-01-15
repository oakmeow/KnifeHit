using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Config
    private float speed = 1f;
    
    void Update()
    {
        transform.Rotate(0f, -speed, 0f);
    }

    public void StopRotate()
    {
        speed = 0f;
    }
}
