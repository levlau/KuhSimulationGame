using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuh : MonoBehaviour
{
    string Name = "Default";
    int Alter = 0;

    float Milchstand = 0f;
    float Gewicht = 5f;
    float FutterLeft = 5f;

    //Game stuff
    Animator animator;

    //UNITY FUNCTIONS
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.Play("OnClick", 0);
    }


    //GET FUNCTIONS
    public string GetName()
    {
        return Name;
    }
    public int GetAlter()
    {
        return Alter;
    }
    public float GetMilchstand()
    {
        return Milchstand;
    }
    public float GetGewicht()
    {
        return Gewicht;
    }
    public float GetFutterLeft()
    {
        return FutterLeft;
    }


    //SET FUNCTIONS
    public void Taufen(string name)
    {
        Name = name;
    }


    //CHANGE FUNCTIONS
    public void Fuettern(float amount)
    {
        Gewicht += amount;
        FutterLeft += amount;
    }

    public float Melken()
    {
        float tmp = Milchstand;
        Milchstand = 0;
        return tmp;
    }
}
