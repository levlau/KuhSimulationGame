using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    long money = 0;

    string[] PossibleFood = { "Weizen", "Mais", "Grass", "Mischessen", "Holy Hand Grenade"};

    
}
public class Nutrition
{
    float Weizen = 0.8f;
    float Mais = 0.9f;
    float Grass = 0.75f;
    float Mischessen = 1.2f;
    float HolyHandGrenade = 5.0f;


    public float getWeizen()
    {
        return Weizen;
    }
    public float getMais()
    {
        return Mais;
    }
    public float getGrass()
    {
        return Grass;
    }
    public float getMischessen()
    {
        return Mischessen;
    }
    public float getHolyHandGrenade()
    {
        return HolyHandGrenade;
    }

}
public class Illness
{
    bool NoMilk4u = false;
    bool WeightLoss = false;
    bool Diabetes = false;


    //Krankheitstimer

    int NoMilk4uTime = 0;
    int WeightLossTime = 0;
    string DiabetesTime = "lifetime";

    public void setDiabetes()
    {
        Diabetes = true;
    }

    public void setWeightLoss()
    {
        WeightLoss = true;
    }
    
    public void setNoMilk4u()
    {
        NoMilk4u = true;
    }
}
