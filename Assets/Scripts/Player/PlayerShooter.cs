using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Projectile bulletPrefab;
    [SerializeField] private Transform firePoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}