using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour {
    bool isOn = false;
    Renderer meshRenderer;
    float lerping = 0;

	// Use this for initialization
	void Start ()
    {
        meshRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isOn)
        {
            lerping += Time.deltaTime * 2;
            if (lerping >= 1)
            {
                lerping = 1;
            }

            meshRenderer.material.SetFloat("_wireonoff", lerping);
        }
        else
        {
            lerping -= Time.deltaTime * 2 ;
            if (lerping <= 0)
            {
                lerping = 0;
            }
            meshRenderer.material.SetFloat("_wireonoff", lerping);
        }
	}

    void SetWiresOn(bool on)
    {
        isOn = on;
    }
}
