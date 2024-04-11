using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ResultadoDelTiro
{
    PreparandoTiro,
    Gol,
    fallo,
    nada
}
     
public class Pelota : MonoBehaviour
{
    ResultadoDelTiro ElEstadoAcutual = ResultadoDelTiro.nada;
    // Start is called before the first frame update
    private void Awake()
    {
        Func<ResultadoDelTiro> myFunction = GetResultado;
        SingletonBiblioteca._instancia.LaBiblioteca.Add("GetResultado", myFunction);
        Action<ResultadoDelTiro> MyAction = setResultado;
        SingletonBiblioteca._instancia.LaBiblioteca.Add("SetResultado", MyAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ResultadoDelTiro GetResultado()
    {
        return ElEstadoAcutual;
    }

    public void setResultado(ResultadoDelTiro elResultado)
    {
        ElEstadoAcutual = elResultado;
        Action storedFunction = (Action)SingletonBiblioteca._instancia.LaBiblioteca["InformarELResultado"];
        storedFunction.Invoke();
    }
}
