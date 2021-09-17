using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    int ejem1 = 5;
    int ejem2 = 5;
    int ejem3;


    // Start is called before the first frame update
    void Start()
    {
        int ejem3 = ejem1 + ejem2;
        if (ejem3 < 10)
        {
            print("Estas muerto");
        }
        else if (ejem3 > 10)
        {
            print("Estas vivo");
        }
        else
        {
            print("A saber como estas");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
