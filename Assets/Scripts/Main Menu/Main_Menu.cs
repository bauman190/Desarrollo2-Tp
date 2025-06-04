using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{


    public void Play()
    {
        SceneManager.LoadScene("Map1");
    }


    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
