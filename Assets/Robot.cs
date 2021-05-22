using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : Enemy
{
    public bool isAttacking = false;
    public void Update()
    {
        if (isAttacking)
        {
            attack();
            base.attack();
        }
    }

        void attack()
        {
            Debug.Log("This is a robot attack!!");
        }
    
}
