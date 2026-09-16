using TMPro;
using UnityEngine;

public class ResultView : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private TMP_Text resultText;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void ShowWin(int score)
    {
        Show("YOU WIN!", score);
    }

    public void ShowLose(int score)
    {
        Show("GAME OVER", score);
    }

    private void Show(string message, int score)
    {
        resultText.text = $"{message}\n\nSCORE: {score}\n\nPress R to restart";
        panel.SetActive(true);
    }
}