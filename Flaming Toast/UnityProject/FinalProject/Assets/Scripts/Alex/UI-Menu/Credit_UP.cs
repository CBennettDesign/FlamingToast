using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class Credit_UP : MonoBehaviour {

	public float speed;
	public float distance;

	public float timer = 10f;
	float actualTimer;

	public int sceneNumber;
	public GameObject endPoint;
	public Animator fadeToBlack;

	public GameObject particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + distance, transform.position.z), speed * Time.deltaTime);
		transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, speed * Time.deltaTime);

		actualTimer += Time.deltaTime;

		if (actualTimer >= timer) 
		{
			//SceneManager.LoadScene (sceneNumber);
			particles.SetActive(false);
			fadeToBlack.Play("FadeToBlack");
			Invoke("EndCredit",2f);
		}

		if(XCI.GetButtonDown(XboxButton.B))
		{
			//SceneManager.LoadScene(sceneNumber);
			particles.SetActive(false);
			fadeToBlack.Play("FadeToBlack");
			Invoke("EndCredit",2f);
		}
	
	}
	public void EndCredit(){
		SceneManager.LoadScene (sceneNumber);
	}
}
