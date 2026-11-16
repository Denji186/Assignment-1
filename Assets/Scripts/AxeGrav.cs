using UnityEngine;

public class AxeGrav : MonoBehaviour
{
    public Rigidbody rb;
    public void AxeGrabbing()
    {
        rb.useGravity = true;
    }
}