using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameState State { get; private set; } = GameState.Playing;
    public int Score { get; private set; }
    [SerializeField] private ResultView resultView;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Restart();
    }

    public void AddScore(int amount)
    {
        Score += amount;
    }

    public void Win()
    {
        if (State != GameState.Playing)
            return;

        State = GameState.Won;
        resultView.ShowWin(Score);

        Time.timeScale = 0f;
    }

    public void Lose()
    {
        if (State != GameState.Playing)
            return;

        State = GameState.Lost;
        resultView.ShowLose(Score);

        Time.timeScale = 0f;
    }

    private void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}