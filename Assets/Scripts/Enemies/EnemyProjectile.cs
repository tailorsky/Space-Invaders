using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private GameConfig config;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate(
            Vector2.down * config.EnemyBulletSpeed * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth playerHealth =
            other.GetComponent<PlayerHealth>();

        if (playerHealth == null)
            return;

        playerHealth.TakeDamage(1);

        Destroy(gameObject);
    }
}