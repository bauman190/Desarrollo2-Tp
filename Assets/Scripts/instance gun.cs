using UnityEngine;

public class instancegun : MonoBehaviour
{
    [SerializeField]private GameObject gunPreFab;
    

    void Start()
    {
        Vector3 offset = new Vector3(10f, 0f, 10f); 
        Vector3 posicionInstancia = transform.TransformPoint(offset);

        GameObject gun = Instantiate(gunPreFab, transform.position, transform.rotation);
        gun.transform.SetParent(transform);
    }


}
