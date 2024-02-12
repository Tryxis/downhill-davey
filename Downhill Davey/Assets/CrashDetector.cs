using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ground"))
        {
            Invoke("ReloadScene", reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}