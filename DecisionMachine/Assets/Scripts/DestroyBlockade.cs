using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockade : MonoBehaviour
{
    [SerializeField]
    GameObject objectToDestroy;

    public void OnSceneLoaded()
    {
        Destroy(gameObject);
    }
}
