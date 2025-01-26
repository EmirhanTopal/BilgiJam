using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class videogecısıkı : MonoBehaviour
{
    public string sonsahne; // Geçilecek sahnenin adı
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd; // Video bittiğinde tetiklenecek event
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sonsahne); // Belirtilen sahneyi yükle
    }
}
