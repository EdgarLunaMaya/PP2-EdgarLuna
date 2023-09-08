using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTierra : CuboMaincra
{
    public override void GetInfo()
    {
     base.GetInfo();

     NombreObjeto = "Cubo de Tierra";
        Debug.Log("Nombre Objeto" + NombreObjeto);

     Elemento = "Tierra";
        Debug.Log("Cubo Elemento" + Elemento);

     Color = "Cafe";
        Debug.Log("Cubo Color" + Color);

     Gravedad = 0;
        Debug.Log("Cubo Gravedad" + Gravedad);

     Densidad = 10;
        Debug.Log("Cubo Densidad" + Densidad);

     Daño = 0;
        Debug.Log("Cubo Daño" + Daño);

     Tamaño = 1;
        Debug.Log("Cubo Tamaño" + Tamaño);

    }
    // Start is called before the first frame update
    void Start()
    {
        GetInfo(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
