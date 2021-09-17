using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primero : MonoBehaviour
{
    float mensaje1 = 10f;
    float mensaje2 = 8f;
    float mensaje3;

    string men1 = "Hoy lo logro";
    string men2 = " o puede que no";
    string men3;

    int ejem1 = 5;
    int ejem2 = 5;
    int ejem3;


    // Start is called before the first frame update
    void Start()
    {
        // Variable float
        // float mensaje3 = mensaje1 - mensaje2;
        //print(mensaje3);


        // Variable string
        //string men3 = men1 + men2;
        //print(men3);


        //Estructura de control 
       
        int ejem3 = ejem1 + ejem2;
        if (ejem3 < 10)
        {
            print ("Estas muerto");
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
