using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneTransitionWithVideo : MonoBehaviour
{
    public string Level1; // Geçilecek sahnenin adý
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd; // Video bittiðinde tetiklenecek event
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(Level1); // Belirtilen sahneyi yükle
    }
}
