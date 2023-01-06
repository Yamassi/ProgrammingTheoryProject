using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    void Start()
    {
        Debug.Log(FindObjectOfType<Cat>().HelloText);
        Debug.Log(FindObjectOfType<Dog>().HelloText);
    }
}
