using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject knifePrefab;
    private int score;
    public TextMeshProUGUI scoreTxt;
    public GameObject background;
    public Board board;
    public GameObject gameover;

    void Start()
    {
        score = 0;

        RandomBackground();
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
        int random_backgound = Random.Range(0, background_count);
        Debug.Log(random_backgound + " / " + background_count);
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
