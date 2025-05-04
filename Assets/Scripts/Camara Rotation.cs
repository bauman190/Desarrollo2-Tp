using UnityEngine;
using UnityEngine.InputSystem;

public class CamaraRotation : MonoBehaviour
{
    [SerializeField] private InputActionReference rotationAction;
    private Vector2 rotationImput;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Rigidbody rb;

    private float xRotation = 0f;
    [SerializeField] private float sensivility = 5f;

    private void OnEnable()
    {
        rotationAction.action.performed += HandleRotationImput;
        rotationAction.action.canceled += HandleRotationCancel;
    }

    private void HandleRotationImput(InputAction.CallbackContext context)
    {
        rotationImput = context.ReadValue<Vector2>();
    }


    private void HandleRotationCancel(InputAction.CallbackContext context)
    {
        rotationImput = Vector2.zero;
    }

    private void Update()
    {
        Vector2 rotation = rotationImput * sensivility * Time.deltaTime;

        rb.transform.Rotate(Vector3.up * rotation.x);

        xRotation -= rotation.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
