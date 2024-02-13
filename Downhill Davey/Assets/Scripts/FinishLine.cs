using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finishLineEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            finishLineEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}
