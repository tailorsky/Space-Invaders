using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameConfig config;

    public int CurrentHealth { get; private set; }

    private void Start()
    {
        CurrentHealth = config.PlayerHealth;
    }

    public void TakeDamage(int damage)
    {
        if (GameManager.Instance.State != GameState.Playing)
            return;

        CurrentHealth -= damage;

        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            GameManager.Instance.Lose();
        }
    }
}