using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
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