using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float playerHealth = 100f;
    public GameObject GameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Hands"))
        {
            if (playerHealth > 0)
            {
                playerHealth -= 25f;
            }
            else
            {
                playerHealth = 0f;
                GameOverUI.SetActive(true);
                Time.timeScale = 0f; // pause the game
            }
        }
    }
}
