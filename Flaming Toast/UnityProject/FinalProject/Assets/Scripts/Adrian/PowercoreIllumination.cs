using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowercoreIllumination : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Junctions junc = GetComponent<Junctions>();
        //Illuminates every peice of wire in set
        for (int i = 0; i  < junc.Wires.Length; i ++)
        {
            junc.setIlluminated(i, true);
        }
	}
	
}
