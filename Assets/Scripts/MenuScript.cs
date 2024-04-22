using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject alertObject;

    public void startGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }
    
    public void openPopup(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    
    public void closePopup(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void multiplayer()
    {
        alertObject.SetActive(true);
    }
}
