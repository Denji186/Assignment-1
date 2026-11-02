using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float playerHealth = 100f;
    public GameObject GameOverUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy Hands"))
        {
            if (playerHealth > 0)
            {
                playerHealth -= 15f;
                Debug.Log(playerHealth);
            }
            else
            {
                playerHealth = 0f;
                Debug.Log(playerHealth);
                //GameOverUI.SetActive(true);
                Time.timeScale = 0f; // pause the game
            }
        }
    }
}
