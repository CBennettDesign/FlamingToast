using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*- Alex Scicluna -*/

public class ShaderTest : MonoBehaviour
{

    private void OnCollisionEnter(Collision colObj)
    {
       // Debug.Log("PING! " + colObj.gameObject.name);


        Material testObjMaterial = colObj.gameObject.GetComponent<Renderer>().material;

        //Debug.Log(testObjMaterial.shader.name);

        testObjMaterial.color = Color.red;

        testObjMaterial.SetFloat("_node", 0.75f);

        if (testObjMaterial.GetFloat("_node") > 0.5f)
        {
            //Debug.Log("HELLO!!!!!");
        }
        else
        {
           // Debug.Log("MEME!");
        }


    }

}
