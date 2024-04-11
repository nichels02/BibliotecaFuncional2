using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosEspectadores : MonoBehaviour
{
    int minimo;
    int maximo;
    // Start is called before the first frame update
    private void Awake()
    {
        Action storedFunction = (Action)SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"];
        storedFunction += definirMaximos;
        SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"] = storedFunction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void definirMaximos()
    {
        switch (SingletonBiblioteca._instancia.LaBiblioteca["GetResultado"])
        {
            case ResultadoDelTiro.PreparandoTiro:
                {

                }
                break;
            case ResultadoDelTiro.Gol:
                {

                }
                break;
            case ResultadoDelTiro.fallo:
                {

                }
                break;
            case ResultadoDelTiro.nada:
                {

                }
                break;
        }
    }

    public void MoverseDeArribaAabajo()
    {

    }
}
