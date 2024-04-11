using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBiblioteca : MonoBehaviour
{
    public static SingletonBiblioteca _instancia { get; private set; }

    //public List<Func<float>> Biblioteca { get; private set; } = new List<Func<float>>();

    public Hashtable LaBiblioteca = new Hashtable();



    private void Awake()
    {
        // Si ya existe una instancia diferente de esta clase, destruimos este objeto
        if (_instancia != null && _instancia != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // Si no hay una instancia existente, establecemos esta instancia como la única
            _instancia = this;
        }
    }
    

    
}
