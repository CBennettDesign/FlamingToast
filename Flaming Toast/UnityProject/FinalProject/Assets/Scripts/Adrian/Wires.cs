using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour {
    bool isOn = false;
    Renderer meshRenderer;
    float lerping = 0;

    //Adjusts the speed of the wires illuminating
    [Range(0.0f, 10.0f)]
    public float speedMultiplyer;

	// Use this for initialization
	void Start ()
    {
        meshRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Lerping for all wire systems
        if (isOn)
        {
            lerping += Time.deltaTime * speedMultiplyer;
            if (lerping >= 1)
            {
                lerping = 1;
            }

            meshRenderer.material.SetFloat("_wireonoff", lerping);
        }
        else
        {
            lerping -= Time.deltaTime * speedMultiplyer;
            if (lerping <= 0)
            {
                lerping = 0;
            }
            meshRenderer.material.SetFloat("_wireonoff", lerping);
        }
	}
    /// <summary>
    /// Bool check for wire system
    /// </summary>
    /// <param name="on"></param>
    void SetWiresOn(bool on)
    {
        isOn = on;
    }
}
