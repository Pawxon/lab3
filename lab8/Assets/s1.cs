using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{

    GameObject[] szukane;

    // Start is called before the first frame update
    void Start()
    {
        szukane = GameObject.FindGameObjectsWithTag("kula");
        foreach (GameObject s in szukane)
        {
            Destroy(s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
