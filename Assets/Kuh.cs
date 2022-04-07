using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuh : MonoBehaviour
{
    //Die random namen die beim erstellen von einer kuh vergeben werden können, weil sie sonst am anfang keinen namen hat
    string[] possibleRandomNames = { "Berta", "Bertha", "Herbert", "Hubert","Huberta", "Hans", "Horst", "Brigitte", "Quengelbert", "Engelbert", "Mina" };

    [SerializeField] GameObject OnClickUI;

    string Name;
    int Age = 0;

    float MilkAmount = 0f;
    float Weight = 5f;
    float AddWeightModifier = 1f;
    float Nutrition = 5f;
    float NutritionModifier = 1f;
    

    //Krankheiten

    bool NoMilk4u = false;
    bool WeightLoss = false;
    bool Diabetes = false;


    //Krankheitstimer

    int NoMilk4uTime = 0;
    int WeightLossTime = 0;
    string DiabetesTime = "lifetime";

    //Game stuff
    Animator animator;

    //UNITY FUNCTIONS
    private void Start()
    {
        Name = possibleRandomNames[Random.Range(0, possibleRandomNames.Length - 1)];    //Random name gebe wenn die kuh erstellt wird
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.Play("OnClick", 0);

        GameObject go = GameObject.FindGameObjectWithTag("UI");
        Destroy(go);

        GameObject ui = Instantiate(OnClickUI);
        ui.SetActive(true);
        ui.GetComponent<CanvasPositioner>().Constructor(gameObject);
    }


    //GET FUNCTIONS
    public string GetName()
    {
        return Name;
    }
    public int GetAge()
    {
        return Age;
    }
    public float GetMilkamount()
    {
        return MilkAmount;
    }
    public float GetWeight()
    {
        return Weight;
    }
    public float GetNutrition()
    {
        return Nutrition;
    }


    //SET FUNCTIONS
    public void SetName(string name)
    {
        Name = name;
    }
    public void SetIllnes()
    {
        int rndTmp = 0;
        rndTmp = Random.Range(0, 2);

        switch (rndTmp)
        {
            case 0:
                NoMilk4u = true;
                NoMilk4uTime = 5 + Random.Range(0, 20);
                break;

            case 1:
                WeightLoss = true;
                WeightLossTime = 5 + Random.Range(0, 20);
                break;

            case 2:
                Diabetes = true;
                break;

            default:
                break;
        }
    }

    //CHANGE FUNCTIONS
    public void Feed(float amount, float FoodWeightModifier, float FoodNutritionModifier)
    {
        Weight += amount * AddWeightModifier * FoodWeightModifier;
        Nutrition += amount * NutritionModifier * FoodNutritionModifier;
    }

    public float Milk()
    {
        float tmp = MilkAmount;
        MilkAmount = 0;
        return tmp;
    }
    public void ChangeAge()
    {
        if (Age > 0)
        {
            Age++;
        }
        SetIllnes();
    }


    //Krankheiten

    public void NoMilk4()
    {

    }
}
