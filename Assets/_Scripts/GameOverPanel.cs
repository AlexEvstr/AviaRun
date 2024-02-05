using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private TMP_Text _bestScore;

    private void Start()
    {
        _score.text = "Score: " + Score.score.ToString();
        _bestScore.text = "Score: " + Score.bestScore.ToString();
    }

    public void TryAgainBtn()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuScene");
    }    
}