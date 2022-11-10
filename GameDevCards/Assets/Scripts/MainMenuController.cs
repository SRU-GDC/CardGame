using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController: MonoBehaviour
{
	//Button to load Chapters
    public void ToChapters()
    {
        SceneManager.LoadScene("Chapters");
    }

    //Button to load Game
    public void ToGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    //Button to Open Options
    public void ToOptions()
    {   //Pop-Menu sliders for options
        Debug.Log("Pop-Up Menu Options");
    }
	
	//Button to load Gallery
    public void ToGallery()
    {
        Debug.Log("To Gallery");
        //SceneManager.LoadScene("Gallery");
    }
	
	//Button to Exit Game
    public void ExitGame()
    {
        
    }
	

}
