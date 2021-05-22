using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CoroutineA());
        StartCoroutine("ColourTest");
        colorTest();
       
    }
   IEnumerator colorTest()
    {
        print("Start of corotine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;
        print("End of corotine");
    }

    // Update is called once per frame
    void ColorsTest()
    {
        print("Start of normal function");
    }
}
