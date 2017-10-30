using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StartGame : MonoBehaviour
{
    
	public void StartScene(int a_buildIndex)
	{
        //get the current scene and unload it
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(currentScene.buildIndex);

        //Load the new scene
		SceneManager.LoadScene(a_buildIndex);

        //Clear all ui panels
        GameObject.Find("UI - System").GetComponent<UI_Menu_Manager>().ClearPanels();

        //Set time.timescale to 1
        Time.timeScale = 1;
	} 
	
 
}
