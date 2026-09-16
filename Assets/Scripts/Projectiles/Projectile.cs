using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float lifeTime = 3f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}