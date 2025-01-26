using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneL2 : MonoBehaviour
{
    [SerializeField] private bool loadScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && loadScene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.CompareTag("Player") && !loadScene)
        {
            SceneManager.LoadScene("video2");
        }
    }
}
