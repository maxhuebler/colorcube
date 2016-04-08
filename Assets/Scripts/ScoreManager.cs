using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public float score;
    public float best;

    public Transform player;

    public Text scoreText;
    public Text bestText;

    // Use this for initialization
    void Start()
    {
        transform.position = player.position;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = (Mathf.Round(Vector3.Distance(player.position, transform.position))) * 15;

        if (score > best)
        {
            best = score;
        }
        bestText.text = best.ToString();
    }
}