using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwich : MonoBehaviour
{
    public int counter;

    public void LoadScene1()
    {
        Application.LoadLevel(1);
        counter = 1;
    }

    public void LoadScene2()
    {
        Application.LoadLevel(2);
        counter = 2;
    }
}
