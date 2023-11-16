using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    bool gameHasEnded = false;

    public void EndGame()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Restart();
            //Restart game or give option to restart
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
