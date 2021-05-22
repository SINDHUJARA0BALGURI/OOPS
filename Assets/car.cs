using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class car //this is empty car class
{
    //attributes or properties
   public  string carName;
    public int makeYear;
    public float maxSpeed;
    //constructor
    public car()
    {
        Debug.Log("Car Default Constructor called");
    }
    public car(float maximumSpeed)
    {
        maxSpeed = maximumSpeed;
        Debug.Log("second constructor called");
        Debug.Log("maximumSpeed:" + maxSpeed);
    }
    public car(int makeYear,string carName)
    {
        this.makeYear = makeYear;
        this.carName = carName;
    }

    //behaviour or methods
    public void Drive()
    {
        Debug.Log("The name of the car is:"+carName);
    }
   public  void ApplyBrake()
    {
        Debug.Log("This is to apply car brake");
    }
 public float Speed()
    {
        Debug.Log("The max speed of the car:" + maxSpeed);
        return maxSpeed;

    }
    public void printCarDetails()
    {
        Debug.Log("The car name is: " + carName);
        Debug.Log("The car makeYear is: " + makeYear);
        Debug.Log("The car max Speed is: " + maxSpeed);
    }

}

