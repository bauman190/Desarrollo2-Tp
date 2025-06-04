using UnityEngine;

public class Enemy : MonoBehaviour , IDamageable
{
    [SerializeField] private float life = 50f;


    public void takeDamage(float damage)
    {
        life -= damage;

        if(life <= 0 )
        {
            Destroy(gameObject);
        }
        Debug.Log("Enemy Reciving damage");
    }
}
