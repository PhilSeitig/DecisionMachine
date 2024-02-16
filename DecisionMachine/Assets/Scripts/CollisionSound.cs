using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
