using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    void Saludo (string hola)
    {
        print("hola" + hola);
    }


    // Start is called before the first frame update
    void Start()
    {
        Saludo("gente");
        Saludo("chicos");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
