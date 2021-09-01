using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int maxMonster = 10;

    public Text scoreText;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();

        PlayerPrefs.SetInt("HighScore", score);

        maxMonster++;
    }

    public void MonsterLimit()
    {
        maxMonster--;
    }

    public void Update()
    {
        if (maxMonster == 0)
        {
            PlayerDied();
        }
    }

    void PlayerDied()
    {
            SceneManager.LoadScene("GameOver");
    }
}