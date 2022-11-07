using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	//Button to load Chapters
    public void toChapters()
    {
        SceneManager.LoadScene("Chapters");
    }
	
	//Button to Open Options
    public void toOptions()
    {
        //Pop-Menu sliders for options
    }
	
	//Button to load Gallery
    public void toGallery()
    {
        SceneManager.LoadScene("Gallery");
    }
	
	//Button to Exit Game
    public void exitGame()
    {
        Application.Quit();
    }
	

}