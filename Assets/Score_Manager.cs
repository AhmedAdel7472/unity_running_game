using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public static Score_Manager instance;
    public Text scoreText;
    
    int score = 0;
    
    void Awake()
    {
        instance = this;
    }
    
    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}