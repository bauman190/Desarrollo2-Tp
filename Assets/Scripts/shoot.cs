using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class shoot : MonoBehaviour
{
    [SerializeField] private Transform Tip;
    [SerializeField] private GameObject BulletPreFab;
    [SerializeField] private InputActionReference shootAction;

    private void OnEnable()
    {
        shootAction.action.performed += HandleShootImput;
    }

    private void HandleShootImput(InputAction.CallbackContext context)
    {
        GameObject bullet = Instantiate(BulletPreFab, Tip.position, transform.rotation);
    }

}
