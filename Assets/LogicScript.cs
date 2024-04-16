using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;

    [ContextMenu("Inscrease Score")]
    public void updateScore(int addScore)
    {
        playerScore = playerScore + addScore;
        scoreText.text = playerScore.ToString();
    }
}
