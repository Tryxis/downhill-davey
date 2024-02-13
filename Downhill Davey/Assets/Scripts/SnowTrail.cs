using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{

    [SerializeField] ParticleSystem snowTrail;
    [SerializeField] AudioClip snowBoard;
    [SerializeField] float snowBoardVolume = 1.5f;
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            snowTrail.Play();
            GetComponent<AudioSource>().PlayOneShot(snowBoard, snowBoardVolume);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            snowTrail.Stop();
            GetComponent<AudioSource>().Stop();
        }
    }

     
}
