using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 1;
    [SerializeField] private int score = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            GameManager.Instance.AddScore(score);

            EnemyGrid grid = GetComponentInParent<EnemyGrid>();
            grid.EnemyDestroyed();

            Destroy(gameObject);
        }
    }
}