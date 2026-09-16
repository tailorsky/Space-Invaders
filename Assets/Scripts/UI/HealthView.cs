using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Image[] healthIcons;

    private void Update()
    {
        if (playerHealth == null)
            return;

        int health = playerHealth.CurrentHealth;

        for (int i = 0; i < healthIcons.Length; i++)
        {
            healthIcons[i].gameObject.SetActive(i < health);
        }
    }
}