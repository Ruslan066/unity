using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHeart : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
        else if (other.gameObject.tag == "Player2")
            Destroy(gameObject);
    }
}
