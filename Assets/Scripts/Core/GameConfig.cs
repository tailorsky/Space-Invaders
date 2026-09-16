using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "SpaceInvaders/Game Config")]
public class GameConfig : ScriptableObject
{
    [Header("Player")]
    [SerializeField] private int playerHealth = 3;
    [SerializeField] private float playerSpeed = 5f;

    [Header("Player Projectile")]
    [SerializeField] private float playerBulletSpeed = 8f;
    [SerializeField] private int playerBulletDamage = 1;

    [Header("Enemies")]
    [SerializeField] private int rows = 4;
    [SerializeField] private int columns = 8;
    [SerializeField] private float spacingX = 1.2f;
    [SerializeField] private float spacingY = 1f;
    [SerializeField] private int enemyHealth = 1;
    [SerializeField] private int enemyScore = 100;

    [Header("Enemy Descent")]
    [SerializeField] private float descentInterval = 3f;
    [SerializeField] private float descentStep = 0.5f;

    [Header("Enemy Shooting")]
    [SerializeField] private float minShootInterval = 1f;
    [SerializeField] private float maxShootInterval = 3f;
    [SerializeField] private float enemyBulletSpeed = 5f;
    
    public int PlayerHealth => playerHealth;
    public float PlayerSpeed => playerSpeed;

    public float PlayerBulletSpeed => playerBulletSpeed;
    public int PlayerBulletDamage => playerBulletDamage;

    public int Rows => rows;
    public int Columns => columns;
    public float SpacingX => spacingX;
    public float SpacingY => spacingY;
    public int EnemyHealth => enemyHealth;
    public int EnemyScore => enemyScore;

    public float DescentInterval => descentInterval;
    public float DescentStep => descentStep;

    public float MinShootInterval => minShootInterval;
    public float MaxShootInterval => maxShootInterval;
    public float EnemyBulletSpeed => enemyBulletSpeed;
}