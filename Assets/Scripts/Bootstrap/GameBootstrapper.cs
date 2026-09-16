using UnityEngine;

public class GameBootstrapper : MonoBehaviour
{
    [SerializeField] private GameConfig gameConfig;
    [SerializeField] private GameManager gameManager;

    private void Awake()
    {
        if (gameManager == null)
        {
            Debug.LogError("GameBootstrapper: GameManager is not assigned.");
            return;
        }

        gameManager.Initialize(gameConfig);
    }
}