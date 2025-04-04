using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource die;

    [ContextMenu("Increase the score")]
    public void addScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void gameOver()
    {
        die.Play();
        gameOverScreen.SetActive(true);
    }
}
