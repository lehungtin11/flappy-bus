using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public bool isPause = false;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverObject;
    public GameObject pauseGameObject;

    private int currentPlayerPrefs = 0;

    private void Start()
    {
        Time.timeScale = 1f;
        currentPlayerPrefs = PlayerPrefs.GetInt("score");
        highScoreText.text = currentPlayerPrefs.ToString();
    }

    private void Update()
    {
        // Pause/Resume game
        if(Input.GetKeyDown(KeyCode.Escape)) {
            checkPauseGame();
        }
    }

    private void checkPauseGame()
    {
        if (!isPause)
        {
            pauseGame();
        }
        else
        {
            resumeGame();
        }
    }

    [ContextMenu("Inscrease Score")]
    public void updateScore(int addScore)
    {
        playerScore = playerScore + addScore;
        scoreText.text = playerScore.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOverScreen()
    {
        gameOverObject.SetActive(true);

        if(currentPlayerPrefs < playerScore)
            PlayerPrefs.SetInt("score", playerScore);
    }
     
    public void pauseGame()
    {
        if(!isPause)
        {
            pauseGameObject.SetActive(true);
            isPause = true;
            Time.timeScale = 0f;
        }
    }

    public void resumeGame()
    {
        if (isPause)
        {
            pauseGameObject.SetActive(false);
            isPause = false;
            Time.timeScale = 1f;
        }
    }

    public void backToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
