using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    public InputActionReference triggerBtn;
    public InputActionReference GripBtn;
    public Animator handAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = triggerBtn.action.ReadValue<float>();
        float GripValue = GripBtn.action.ReadValue<float>();
        Debug.Log("triggerValue :" + triggerValue);
        Debug.Log("GripValue :" + GripValue);

        handAnimator.SetFloat("Trigger", triggerValue);
        handAnimator.SetFloat("Grip", GripValue);
    }   
}
