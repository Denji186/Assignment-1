using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float playerHealth = 100f;
    public GameObject GameOverUI;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy Hands"))
        {
            if (playerHealth > 0)
            {
                playerHealth -= 25f;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy Hands"))
        {
            if (playerHealth > 0)
            {
                playerHealth -= 25f;
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
