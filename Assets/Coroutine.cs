using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    int num = 0;
   // IEnumerator coroutine;
    void Start()
    {
        // coroutine = ScoreUpdate();
        print("Start");
        StartCoroutine(ScoreUpdate());
       
    }
    private void Update()
    {
       // StartCoroutine(ScoreUpdate());
    }
    IEnumerator ScoreUpdate()
    {
        print("Score" + ++num);
        yield return new WaitForSeconds(5.0f);
        print("End");
    }
      
}
