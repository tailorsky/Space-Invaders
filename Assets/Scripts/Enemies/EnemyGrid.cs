using UnityEngine;

public class EnemyGrid : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private GameConfig config;

    private int enemyCount;
    private float timer;

    private void Start()
    {
        CreateGrid();
    }

    private void Update()
    {
        if (GameManager.Instance.State != GameState.Playing)
            return;

        timer += Time.deltaTime;

        if (timer >= config.DescentInterval)
        {
            timer = 0f;
            transform.position += Vector3.down * config.DescentStep;
        }
    }

    private void CreateGrid()
    {
        float width =
            (config.Columns - 1) * config.SpacingX;

        float height =
            (config.Rows - 1) * config.SpacingY;

        Vector3 startPosition =
            transform.position +
            new Vector3(-width / 2f, height / 2f, 0f);

        for (int row = 0; row < config.Rows; row++)
        {
            for (int column = 0; column < config.Columns; column++)
            {
                Vector3 position =
                    startPosition +
                    new Vector3(
                        column * config.SpacingX,
                        -row * config.SpacingY,
                        0f
                    );

                Instantiate(
                    enemyPrefab,
                    position,
                    Quaternion.identity,
                    transform
                );

                enemyCount++;
            }
        }
    }

    public void EnemyDestroyed()
    {
        enemyCount--;

        if (enemyCount <= 0)
            GameManager.Instance.Win();
    }
}