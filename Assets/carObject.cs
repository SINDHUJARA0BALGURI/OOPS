using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carObject : MonoBehaviour
{
    // Start is called before the first frame update
    //car myCar = new car();
    //car ford = new car();
    //public car myBigCar;
    enum Direction {East,West,North,South}
    void Start()
    {
        Direction mydirection;
        mydirection = Direction.East;
        Debug.Log("mydirection is: " + mydirection);

        
        //myBigCar.printCarDetails();
        //car myCar = new car(150);
       /* car ford = new car();
        car maruthi = new car(2021, "maruthi");
        maruthi.Drive();*/
       /* myCar.carName = "Suzuki";
        myCar.makeYear = 1980;
        myCar.maxSpeed = 150.05f;
        myCar.Drive();
        myCar.Speed();
        ford.carName = "Ford Car";
        ford.makeYear = 2000;
        ford.maxSpeed = 180.0f;
        ford.Drive();
        ford.Speed();*/
        
    }

    Direction GetMyDirection(Direction direction)
    {
        Direction dir;
        dir = Direction.East;
        if (direction == Direction.East)
        {
            dir = Direction.North;
        }
        return dir;
    }

}
