using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreUI;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        BallController ball = collision.gameObject.GetComponent<BallController>();
        ball.Reset();
        score++;
        scoreUI.text = score.ToString("Score: ") + score;
    }
}
