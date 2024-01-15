using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knifePrefab;
    private int score;
    public TextMeshProUGUI scoreTxt;

    void Start()
    {
        score = 0;
    }

    public void SpawnKnife()
    {
        GameObject obj = Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        obj.transform.parent = spawnPoint;
    }

    public void AddScore()
    {
        score++;
        scoreTxt.text = score.ToString();
    }
}
