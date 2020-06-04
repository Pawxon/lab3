using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wypadanie : MonoBehaviour
{


    public GameObject [] kulka;
    bool flaga = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerujKulki", 0.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Return))
        { 
            //GenerujKulki();
            CancelInvoke("GenerujKulki");
            flaga = true;
        }
        if (flaga)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("GenerujKulki", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Invoke("GenerujlElement0", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Invoke("GenerujElement1", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Invoke("GenerujElement2", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Invoke("GenerujElement3", 0.5f);
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                Invoke("GenerujElement4", 0.5f);
            }
        }
        
    }

    void GenerujlElement0()
    {
        Instantiate(kulka[0], transform.position, Quaternion.identity);
    }

    void GenerujElement1()
    {
        Instantiate(kulka[1], transform.position, Quaternion.identity);
    }

    void GenerujElement2()
    {
        Instantiate(kulka[2], transform.position, Quaternion.identity);
    }

    void GenerujElement3()
    {
        Instantiate(kulka[3], transform.position, Quaternion.identity);
    }

    void GenerujElement4()
    {

        Instantiate(kulka[4], transform.position, Quaternion.identity);
    }


    void GenerujKulki()
    {
        int los = Random.Range(0, kulka.Length);
        Instantiate(kulka[los], transform.position, Quaternion.identity);
    }
    
}
