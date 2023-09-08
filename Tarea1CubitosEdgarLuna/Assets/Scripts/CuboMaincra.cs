using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMaincra : MonoBehaviour
{
    public string NombreObjeto = "Cubo Base";
    public string Elemento = "Ninguno";
    public string Color = "Transparente";
    public float Gravedad = 0;
    public float Densidad = 0;
    public int Da�o = 0;
    public int Tama�o = 1;

    public virtual void GetInfo()
    {
        Debug.Log("Nombre: " + NombreObjeto);
        Debug.Log("Elemento: " + Elemento);
        Debug.Log("Color: " + Color);
        Debug.Log("Gravedad: " + Gravedad);
        Debug.Log("Densidad: "+ Densidad);
        Debug.Log("Da�o: " + Da�o);
        Debug.Log("Tama�o: " + Tama�o);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
