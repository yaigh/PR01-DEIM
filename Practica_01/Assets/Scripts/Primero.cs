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

    public int var1 = 3;
    public int var2 = 6;
    public int var3;

    // Start is called before the first frame update
    void Start()
    {
       
        //Ambito publico

        int var3 = var1 * var2;
        print(var3);

    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
