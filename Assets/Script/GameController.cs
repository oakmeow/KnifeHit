using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEditor.VersionControl;

public class GameController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knifePrefab;
    private int score;
    public TextMeshProUGUI scoreTxt;
    public GameObject background;
    public Board board;
    public GameObject gameover;
    public Transform canvas;
    public GameObject messageTxt;

    void Start()
    {
        score = 0;

        RandomBackground();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ResumeGame();
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.PageUp))
            {
                board.SpeedUp();
                GameObject message = Instantiate(messageTxt, canvas);
                message.GetComponent<TextMeshProUGUI>().text = board.GetSpeedText();
            }
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                board.SpeedDown();
                GameObject message = Instantiate(messageTxt, canvas);
                message.GetComponent<TextMeshProUGUI>().text = board.GetSpeedText();
            }
        }
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

    public void RandomBackground()
    {
        int background_count = background.transform.childCount;
        int random_backgound = UnityEngine.Random.Range(0, background_count);
        
        for (int i = 0; i< background_count; i++)
        {
            if (i == random_backgound)
            {
                background.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                background.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void PauseGame()
    {
        board.StopRotate();
        gameover.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
