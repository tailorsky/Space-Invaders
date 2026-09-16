using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");

        transform.position += Vector3.right * input * speed * Time.deltaTime;

        float x = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(x, transform.position.y, 0f);
    }
}