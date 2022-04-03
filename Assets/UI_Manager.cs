using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject KuhClickUI;     //Die UI die aktiviert wird wenn man eine Kuh anklickt
    Kuh kuh;

    private void Start()
    {
        kuh = GetComponent<Kuh>();
    }

    public void ActivateUI()    //wird von der kuh aufgerufen, wenn sie angeklickt wird
    {
        KuhClickUI.SetActive(true);
        
    }
}
