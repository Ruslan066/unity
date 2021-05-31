using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
   public int health = 3;
    public int numberOfHealth;

    public Image[] lives;
    public Sprite fullLives;
    public Sprite emptyLives;
    public int coutLives = 3;
    public static HealthSystem instance = null;
    void Start()
    {
        if (instance == null)
            instance = this;
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Shovel")
        {
            health -= 1;
            if (health < 1)
            {
                // SceneManager.LoadScene("main");
                lives[0].sprite = emptyLives;
                // Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
        if (other.gameObject.tag == "BonusHeart")
        {
            if (health < 3)
                health += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (health > numberOfHealth)
        {

            health = numberOfHealth;
        }
        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLives;

            }
            else
            {
                lives[i].sprite = emptyLives;
            }

           
            if (i < numberOfHealth)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
