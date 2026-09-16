using UnityEngine;

public class EnemyGrid : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;

    [SerializeField] private int rows = 4;
    [SerializeField] private int columns = 8;

    [SerializeField] private float spacingX = 1.2f;
    [SerializeField] private float spacingY = 1f;

    [SerializeField] private float descentInterval = 3f;
    [SerializeField] private float descentStep = 0.5f;

    private float timer;

    private void Start()
    {
        CreateGrid();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= descentInterval)
        {
            timer = 0f;
            transform.position += Vector3.down * descentStep;
        }
    }

    private void CreateGrid()
    {
        float width = (columns - 1) * spacingX;
        float height = (rows - 1) * spacingY;

        Vector3 startPosition = transform.position +
                                new Vector3(-width / 2f, height / 2f, 0);

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Vector3 position = startPosition +
                                    new Vector3(
                                        column * spacingX,
                                        -row * spacingY,
                                        0
                                    );

                Instantiate(enemyPrefab, position, Quaternion.identity, transform);
            }
        }
    }
}