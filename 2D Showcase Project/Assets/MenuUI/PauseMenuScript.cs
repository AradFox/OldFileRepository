using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{

    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale != 0)
            {
                //Pause the game.
                PauseGame();
            }
            else
            {
                //Resume the game.
                ResumeGame();
            }
        } 
    }
    public void PauseGame()
    {
        //Pause the game.
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    public void ResumeGame()
    {
        //Resume the game.
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void Quit()
    {
        Application.Quit();

    }
}
