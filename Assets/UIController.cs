using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Action storedFunction = (Action)SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"];
        storedFunction += MostrarResultado;
        SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"] = storedFunction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarResultado()
    {

    }
}
