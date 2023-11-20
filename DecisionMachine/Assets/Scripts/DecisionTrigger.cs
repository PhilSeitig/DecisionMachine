using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTrigger : MonoBehaviour
{
    // Show menu when cup is not empty
    public GameObject menu;

    void OnTriggerEnter(Collider cup)
    {
        if (cup.tag == "not empty")
        {
            menu.SetActive(true);
        }
    }
}
