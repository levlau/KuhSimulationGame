using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasPositioner : MonoBehaviour
{
    Vector3 position;

    [SerializeField] Vector3 cowPosOffset;
    Vector3 mainCameraPos;

    GameObject cow;
    Kuh kuh;

    private void Start()
    {
        kuh = cow.GetComponent<Kuh>();

        UpdateStats();
    }

    private void UpdateStats()
    {
        GameObject.Find("name").GetComponent<TextMeshProUGUI>().text = kuh.GetName();
        GameObject.Find("weight").GetComponent<TextMeshProUGUI>().text = kuh.GetWeight().ToString() + " kg";
        GameObject.Find("age").GetComponent<TextMeshProUGUI>().text = kuh.GetAge().ToString() + " D";
        GameObject.Find("milk").GetComponent<TextMeshProUGUI>().text = kuh.GetMilkamount().ToString() + " l";
        GameObject.Find("nutrition").GetComponent<TextMeshProUGUI>().text = kuh.GetNutrition().ToString();
    }

    public void Constructor(GameObject clickedCow)
    {
        cow = clickedCow;
    }

    private void Update()
    {
        mainCameraPos = Camera.main.transform.position;
        position = cow.transform.position + cowPosOffset;

        transform.LookAt(mainCameraPos);
        transform.position = position;

        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }

    public void CowAction(string action)
    {
        switch (action)
        {
            case "milk":
                kuh.Milk();
                break;
        }

        UpdateStats();    
    }
}
