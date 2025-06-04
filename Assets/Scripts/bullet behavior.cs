using UnityEngine;

public class bulletbehavior : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float bulletSpeed = 100.0f;
    private float lifeTiem = 7f;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, lifeTiem);
    }

    void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.takeDamage(damage);
        }

        Destroy(gameObject);
    }
}
