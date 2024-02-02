using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _BestscoreText;
    public static int score;
    private int _bestScore;

    private void OnEnable()
    {
        //score = PlayerPrefs.GetInt("score", 0);
        _bestScore = PlayerPrefs.GetInt("bestScore", 0);
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
            yield return new WaitForSeconds(1f);
        }
    }

    private void Update()
    {
        if (score > _bestScore)
            _bestScore = score;

        _scoreText.text = "Score: " + score.ToString();
        _BestscoreText.text = "Best:    " + _bestScore.ToString();
    }

    private void OnDisable()
    {
        //PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("bestScore", _bestScore);
    }
}