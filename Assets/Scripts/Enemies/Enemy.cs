using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 1;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
            Destroy(gameObject);
    }
}