using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*- Alex Scicluna -*/

public class WinLossStates : MonoBehaviour
{
    public Slider healthSlider;
    public Slider progressSlider;
    public Slider oxygenSlider;

    public GameObject winSate;
    public GameObject lossState;


    private bool gameWin;
    private bool gameLoss;

 
    //User Input || !Physics
    private void Update()
    {
        //Debug.Log(healthSlider.value + ":" + progressSlider.value + ":" + oxygenSlider.value);

        if (healthSlider.value == 0 || oxygenSlider.value == 0 && !gameWin)
        {
            //Game over try again
            lossState.GetComponent<Image>().enabled = true;

            winSate.GetComponent<Image>().enabled = false;

            Time.timeScale = 0.2f;
            gameLoss = true;
        }
        else if (progressSlider.value == progressSlider.maxValue && !gameLoss)
        {
            //Win yay
            lossState.GetComponent<Image>().enabled = false;

            winSate.GetComponent<Image>().enabled = true;

            Time.timeScale = 0.2f;
            gameWin = true;
        }

    }

 
}
