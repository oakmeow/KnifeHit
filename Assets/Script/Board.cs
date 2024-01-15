using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Config
    private float speed = 1f;
    private float speed_min = 0.1f;
    private float speed_max = 3f;
    private float speed_step = 0.1f;
    
    void Update()
    {
        transform.Rotate(0f, -speed, 0f);
    }

    public void StopRotate()
    {
        speed = 0f;
    }
    public void SpeedDown()
    {
        if (speed > speed_min)
        {
            speed -= speed_step;
        }
    }
    public void SpeedUp()
    {
        if (speed < speed_max)
        {
            speed += speed_step;
        }
    }
    public string GetSpeedText()
    {
        // 
        return "Administrator : speed[ " + Mathf.Round(speed * 10) * 0.1 + " ]";
    }
}
