using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSwich : MonoBehaviour
{
  public void LoadScene1()
    {
        Application.LoadLevel(1);
    }

    public void LoadScene2()
    {
        Application.LoadLevel(2); 
    }
}
