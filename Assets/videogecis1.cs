using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videogecis1 : MonoBehaviour
{
  
    public string Level1; // Ge�ilecek sahnenin ad�
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd; // Video bitti�inde tetiklenecek event
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(Level1); // Belirtilen sahneyi y�kle
    }
}

