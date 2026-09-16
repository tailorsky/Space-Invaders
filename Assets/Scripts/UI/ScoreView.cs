using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int lastScore = -1;

    private void Update()
    {
        if (GameManager.Instance == null)
            return;

        int score = GameManager.Instance.Score;

        if (score == lastScore)
            return;

        lastScore = score;
        scoreText.text = $"SCORE: {score}";
    }
}