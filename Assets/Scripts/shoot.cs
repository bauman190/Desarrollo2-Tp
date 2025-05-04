using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private GameObject GunPreFab;
    [SerializeField] private GameObject BulletPreFab;


    void Start()
    {
        GameObject bullet = Instantiate(BulletPreFab, GunPreFab.transform.Find("Tip").position, transform.rotation);
    }

}
