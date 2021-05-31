using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFinish : MonoBehaviour
{
    public int Level;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene("main");
        else if (other.gameObject.tag == "Player2")
            SceneManager.LoadScene("main");
    }
}
