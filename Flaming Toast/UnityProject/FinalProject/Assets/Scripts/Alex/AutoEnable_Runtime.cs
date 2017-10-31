using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*- Alex Scicluna -*/
 
public class AutoEnable_Runtime : MonoBehaviour
{

    public GameObject[] ObjectsToEnableAtRuntime; 

    void Start()
    {
        foreach (var obj in ObjectsToEnableAtRuntime)
        {
            obj.SetActive(true);
        }
    }

   

}
