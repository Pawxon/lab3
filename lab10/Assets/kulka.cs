using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulka : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public GameObject [] kuleczka;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, y, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            int los = Random.Range(0, kuleczka.Length);
            Instantiate(kuleczka[los], pozycja, Quaternion.identity);
        }
        

    }
}
