using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip audioShovel;
    public AudioClip audioHeart;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shovel")
        {
            GetComponent<AudioSource>().PlayOneShot(audioShovel);
        }
        if (other.gameObject.tag == "BonusHeart")
        {
            GetComponent<AudioSource>().PlayOneShot(audioHeart);
        }
    }
}
