using UnityEngine;
using UnityEngine.InputSystem;

public class movment : MonoBehaviour
{
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference jumpAction;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 10;
    [SerializeField] private float jumpForce = 10;

    private Vector2 moveImput;
    private bool jump;

    private void OnEnable()
    {
        moveAction.action.started += HandleMoveImput;
        moveAction.action.performed += HandleMoveImput;
        moveAction.action.canceled += HandleMoveImput;
        jumpAction.action.performed += HandleJumpImput;
    }

    private void HandleMoveImput(InputAction.CallbackContext context)
    {
        moveImput = context.ReadValue<Vector2>();
    }

    private void HandleJumpImput(InputAction.CallbackContext context)
    {        
        jump = true;
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(moveImput.x, 0, moveImput.y) * speed, ForceMode.Force);

        if (jump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }      
            
    }
}
