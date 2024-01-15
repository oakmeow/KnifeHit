using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knifePrefab;
    private int score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        
    }

    public void SpawnKnife()
    {
        GameObject obj = Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        obj.transform.parent = spawnPoint;
    }

    public void AddScore()
    {
        score++;
    }
}
