using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;

    public TMP_Text scoreText;
    public TMP_Text timerText;

    public float time = 60f;

    public GameObject gameOverPanel;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        time -= Time.deltaTime;

        timerText.text = "Time : " + Mathf.Ceil(time);

        if (time <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score : " + score;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex);
    }
}