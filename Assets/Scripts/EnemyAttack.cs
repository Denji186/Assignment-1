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
       
    }

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
}
