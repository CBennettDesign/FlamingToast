using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class OxygenLerp : MonoBehaviour {

    private Base_System system;
    private Oxygen_System oxygen;
    public PostProcessingProfile ppProfile;
    private float timer;
    public float effectStart = 50.0f;
    public float effectEnd = 10.0f;
    public float MinIntensity;
    public float MaxIntensity;
    public float MinSaturation;
    public float MaxSaturation;

    // Use this for initialization
    void Start ()
    {
        oxygen = GetComponent<Oxygen_System>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        //Adrian Visual camera lerping
        
        if (system.OxygenLevel > effectStart)
        {
            timer = 0;
        }
        else
        {
            timer = 1 - (system.OxygenLevel - effectEnd) / (effectStart - effectEnd);
        }
        
        VignetteModel.Settings SettingsVignette = ppProfile.vignette.settings;
        SettingsVignette.intensity = Mathf.Lerp(MinIntensity, MaxIntensity, timer);
        ppProfile.vignette.settings = SettingsVignette;

        ColorGradingModel.Settings SettingsGradingModel = ppProfile.colorGrading.settings;
        SettingsGradingModel.basic.saturation = Mathf.Lerp(MinSaturation, MaxSaturation, timer);
        ppProfile.colorGrading.settings = SettingsGradingModel;


    }
}
