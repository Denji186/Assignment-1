using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class XRFloor : MonoBehaviour
{
    private CharacterController controller;
    private float verticalVelocity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity += Physics.gravity.y * Time.deltaTime;
        }

        controller.Move(
            Vector3.up * verticalVelocity * Time.deltaTime
        );
    }
}