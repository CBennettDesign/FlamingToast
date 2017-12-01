using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class CameraBloomLerping : MonoBehaviour {
    
    //PostProcessingProfile
    public PostProcessingProfile ppProfile;
    //Tooltip for Min - Max
    //[Header("Min - Max Bloom value")]
    ////Max lerp
    //[Range(0.4f, 0.6f)]
    //float Max;
    ////Min lerp
    //float Min;
    //Range for lerping
    
    //Public Bloom Variable
    public float MinBloom = 0.5f;
    public float MaxBloom = 1.0f;
    float timer = 0;
    bool isFadeingIn = true;


    // Use this for initialization
    void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update ()
    {
        BloomModel.Settings bloomSettings = ppProfile.bloom.settings;
        //Timer for bloom Lerp
        if (isFadeingIn)
        {
            timer += Time.deltaTime;

            if (timer >= 1)
            {
                timer = 1;
                isFadeingIn = false;
            }
        }
        else
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                isFadeingIn = true;
            }
        }

        //Adjusting bloom values
        bloomSettings.bloom.intensity = Mathf.Lerp(MinBloom, MaxBloom, timer);

        ppProfile.bloom.settings = bloomSettings;
        
        

	}
}
