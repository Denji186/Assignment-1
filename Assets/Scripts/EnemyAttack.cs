using UnityEngine;
using UnityEngine.UI;

public class EnemyAttack : MonoBehaviour
{
    public float playerHealth = 100f;
    public GameObject GameOverUI;
    public Image healthbar;

    public AudioSource enemyAttackAudio;
    public AudioClip enemyAttackClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy Hands"))
        {
            if (playerHealth > 0)
            {
                playerHealth -= 0.15f;
                healthbar.fillAmount -= 0.15f;
                enemyAttackAudio.PlayOneShot(enemyAttackClip);
                Debug.Log(playerHealth);
            }
            else
            {
                playerHealth = 0f;
                healthbar.fillAmount = 0;
                Debug.Log(playerHealth);
                //GameOverUI.SetActive(true);
                Time.timeScale = 0f; // pause the game
            }
        }
    }
}
