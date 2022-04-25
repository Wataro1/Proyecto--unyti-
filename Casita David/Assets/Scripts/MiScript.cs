using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour


{
    public string nombreMio;
    public string nombreAmigo;
    public int edadMio;
    public int edadAmigo;
    private int suma;
    
    void Start()
    {
        Debug.Log(nombreMio + nombreAmigo);
        suma = edadAmigo + edadMio;
        Debug.Log(suma);
        


    }

    // Update is called once per frame
    void Update()
    {

    }
}
