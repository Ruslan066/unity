using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("game");
    }
   

    public void Loadto()
    {
        SceneManager.LoadScene("Levels");
    }
}
