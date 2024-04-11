using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquero : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Action storedFunction = (Action)SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"];
        storedFunction += IrALaPosicion;
        SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"] = storedFunction;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IrALaPosicion()
    {

    }
}
