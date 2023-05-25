using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabInstantiate : MonoBehaviour
{
    public GameObject cubePrefab;
    void Start()
    {
        Instantiate(cubePrefab, new Vector3(-4.2f, 1.8f, 4.2f), Quaternion.Euler(0, 0, 0));
        Instantiate(cubePrefab, new Vector3(-12.6f, 1.8f, 4.2f), Quaternion.Euler(0, 90, 0));
        Instantiate(cubePrefab, new Vector3(-4.2f, 1.8f, 21.4f), Quaternion.Euler(0, 90, 0));
        Instantiate(cubePrefab, new Vector3(21.5f, 1.8f, 4.2f), Quaternion.Euler(0, 180, 0));
        Instantiate(cubePrefab, new Vector3(13f, 1.8f, 12.7f), Quaternion.Euler(0, 90, 0));
        Instantiate(cubePrefab, new Vector3(-21.5f, 1.8f, -21.5f), Quaternion.Euler(0, 0, 0));
        Instantiate(cubePrefab, new Vector3(4.5f, 1.8f, 13f), Quaternion.Euler(0, 180, 0));
        Instantiate(cubePrefab, new Vector3(-4.2f, 1.8f, -13f), Quaternion.Euler(0, -90, 0));
        Instantiate(cubePrefab, new Vector3(13f, 1.8f, -21.4f), Quaternion.Euler(0, -90, 0));
        Instantiate(cubePrefab, new Vector3(13f, 1.8f, -4.2f), Quaternion.Euler(0, 180, 0));
    }
}
