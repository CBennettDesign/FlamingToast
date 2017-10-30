using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_StartGame : MonoBehaviour
{

	private int sceneIndexToLoad = 1;

	
	public void StartScene()
	{
		SceneManager.LoadScene(sceneIndexToLoad);
	} 
	
 
}
