using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;

    public GameObject player1Goal;
    public GameObject player2Goal;

    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<Movement>().Reset();
        player2.GetComponent<Movement>().Reset();
    }

    public void Player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }
}
