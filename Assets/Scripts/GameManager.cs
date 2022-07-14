using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score;

    private void Start()
    {
        scoreText.text = score.ToString();
    }
    public void UpScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
