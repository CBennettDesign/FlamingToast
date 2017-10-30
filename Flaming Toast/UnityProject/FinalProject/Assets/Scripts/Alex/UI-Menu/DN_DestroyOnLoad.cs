using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_DestroyOnLoad : MonoBehaviour
{
    //When chaging scenes do not destroy this object
	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);
    }
		
}
