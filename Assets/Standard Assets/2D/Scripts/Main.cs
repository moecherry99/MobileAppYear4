
using UnityEngine;

public class Main : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject YouWinText;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("");
            Invoke("Restart", restartDelay);
        }
    }    
    public void CompleteLevel()
    {
        YouWinText.SetActive(true);
        Debug.Log("Won");
    }

}
