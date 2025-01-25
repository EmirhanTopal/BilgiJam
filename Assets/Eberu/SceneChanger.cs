using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadBoranScene()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadBoranScene2()
    {
        SceneManager.LoadScene("deterjan");
    }
}
