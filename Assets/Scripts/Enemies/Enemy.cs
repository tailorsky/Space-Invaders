using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameConfig config;

    private int health;

    private void Awake()
    {
        health = config.EnemyHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health > 0)
            return;

        GameManager.Instance.AddScore(config.EnemyScore);

        EnemyGrid grid = GetComponentInParent<EnemyGrid>();

        if (grid != null)
            grid.EnemyDestroyed();

        Destroy(gameObject);
    }
}