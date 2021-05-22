using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:MonoBehaviour
{
    public void attack()
    {
        Debug.Log("Enemy Attack!!");
        GetComponent<Renderer>().material.color = Color.red;
    }
}
