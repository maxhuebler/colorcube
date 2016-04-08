using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int highscore;

    public Transform player;

    public Text scoreText;
    public Text scoreText2;
    public Text highscoreText;

    // Use this for initialization
    void Start()
    {
        transform.position = player.position;
        highscore = PlayerPrefs.GetInt("High Score", score);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        scoreText2.text = score.ToString();
        highscoreText.text = highscore.ToString();
    }

    public static void CheckHighScore()
    {
        if (score > highscore)
        {
            PlayerPrefs.SetInt("High Score",score);
        }
    }
}