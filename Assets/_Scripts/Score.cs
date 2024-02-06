using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _BestscoreText;
    public static int score;
    public static float time = 1f;
    public static int bestScore;

    private void OnEnable()
    {
        //score = PlayerPrefs.GetInt("score", 0);
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
    }

    private void Start()
    {
        StartCoroutine(ScoreIncrease());
    }

    private IEnumerator ScoreIncrease()
    {
        while (true)
        {
            score++;
            yield return new WaitForSeconds(time);
        }
    }

    private void Update()
    {
        if (score > bestScore)
            bestScore = score;

        _scoreText.text = "Score  : " + score.ToString();
        _BestscoreText.text = "Best:    " + bestScore.ToString();
    }

    private void OnDisable()
    {
        //PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("bestScore", bestScore);
        score = 0;
    }
}