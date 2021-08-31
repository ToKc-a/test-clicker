using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text scoreText;
    //public Text gameOverText;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void PlayerDied()
    {
        SceneManager.LoadScene("GameOver");
        Time.timeScale = 2;
    }
}
