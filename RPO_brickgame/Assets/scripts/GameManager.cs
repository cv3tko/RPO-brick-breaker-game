using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameOver = false;
    
    public void endGame()
    {
        if(!gameOver)
        {
            gameOver = true;
            Debug.Log("Game over");
            SceneManager.LoadScene("gameOver");
        }

    }

}
