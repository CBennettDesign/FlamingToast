using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialTrigger : MonoBehaviour {


    /// <summary>
    /// NO LONGER USED BUT KEPTS FOR FUTURE UPGRADES 
    /// </summary>
    

    //Canvas being switched
    public Canvas canvas;
    //Question Mark to be switched
    public GameObject QuestionMark;
    //Delay time
    public int delayTime = 2;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            //Enables Tooltip
            canvas.enabled = true;
            StartCoroutine(FadeIn());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Begins Timer
            StartCoroutine(DelayTimer());
        }
    }
    IEnumerator DelayTimer()
    {
        yield return new WaitForSeconds(delayTime);

        //Disables Tooltip
        StartCoroutine(FadeOut());
        Destroy(GetComponent<BoxCollider>());
        
    }
    IEnumerator FadeIn()
    {
        CanvasGroup canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 3;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
    IEnumerator FadeOut()
    {
        CanvasGroup canvasGroup = canvas.GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 3;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }

}
