using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float speed = 3f;
    
    void Update()
    {
        transform.Rotate(0f, -speed, 0f);
    }
}
