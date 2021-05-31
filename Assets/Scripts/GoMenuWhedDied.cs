using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMenuWhedDied : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthSystem.instance.health < 1 && HealsSystem2.instance.health < 1)
            SceneManager.LoadScene("main");
    }
}
