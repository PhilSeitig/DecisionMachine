using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockade : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2f); //Destroy Game Object when Scene is loaded after two seconds
    }
}
