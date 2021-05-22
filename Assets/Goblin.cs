using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin :Enemy
{
    public void Start()
    {
        // attack();
        
        Goblin myGoblin = new Goblin();
        myGoblin.attack();
        Goblin redGoblin = new RedGoblin();
        redGoblin.attack();
        Goblin whiteGoblin = new WhiteGoblin();
        whiteGoblin.attack();
    }
    public virtual void attack()
    {
        Debug.Log("Goblin Attack!!");
    }
}
public class WhiteGoblin:Goblin
{
    public void attack()
    {
        Debug.Log("WhiteGoblin Attack!!");
    }
}
public class RedGoblin : Goblin
{
    public override void attack()
    {
        Debug.Log("RedGoblin Attack!!");
    }
}
