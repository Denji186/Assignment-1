using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    public float enemyhealth=100;
    public NavMeshAgent enemyNavMesh;

    public bool IsDie = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Axe"))
        {
            if(enemyhealth>0)
            {
                enemyhealth -= 100;
            }
            else
            {
                IsDie = true;
                //enemyNavMesh.gameObject.SetActive(false);
            }
            
        }
    }
}
