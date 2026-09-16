using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    [SerializeField] private EnemyProjectile bulletPrefab;
    [SerializeField] private GameConfig config;

    private float timer;
    private float nextShootTime;

    private void Start()
    {
        SetNextShootTime();
    }

    private void Update()
    {
        if (GameManager.Instance.State != GameState.Playing)
            return;

        timer += Time.deltaTime;

        if (timer < nextShootTime)
            return;

        timer = 0f;

        Shoot();
        SetNextShootTime();
    }

    private void SetNextShootTime()
    {
        nextShootTime = Random.Range(
            config.MinShootInterval,
            config.MaxShootInterval
        );
    }

    private void Shoot()
    {
        if (transform.childCount == 0)
            return;

        int randomIndex =
            Random.Range(0, transform.childCount);

        Transform enemy =
            transform.GetChild(randomIndex);

        Instantiate(
            bulletPrefab,
            enemy.position,
            Quaternion.identity
        );
    }
}