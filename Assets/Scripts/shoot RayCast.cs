using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class shootRayCast : MonoBehaviour
{
    [SerializeField] private InputActionReference shootAction;
    [SerializeField] private float maxDistance;
    [SerializeField] private float damage;

    private void OnEnable()
    {
        shootAction.action.performed += HandleShootImput;
    }

    private void HandleShootImput(InputAction.CallbackContext context)
    {
        Shoot();
    }

    private void Shoot()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);

        Debug.DrawLine(ray.origin, ray.direction * maxDistance, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance))
        {

            IDamageable damageable = hit.collider.GetComponent<IDamageable>();

            if (damageable != null)
            {
                damageable.takeDamage(damage);
            }
        }
    }

}
