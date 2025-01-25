using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadDeterjanScene()
    {
        SceneManager.LoadScene("Level1");
    }
}