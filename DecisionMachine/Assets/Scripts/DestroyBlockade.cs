using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockade : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 4f); //Destroy gameObject after 4 seconds
    }
}
