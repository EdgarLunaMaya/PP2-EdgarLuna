using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboArena : CuboMaincra
{
    public override void GetInfo()
    {
        base.GetInfo();

        NombreObjeto = "Cubo de Arena";
        Debug.Log("Nombre Objeto" + NombreObjeto);

        Elemento = "Arena";
        Debug.Log("Cubo Elemento" + Elemento);

        Color = "Amarillo";
        Debug.Log("Cubo Color" + Color);

        Gravedad = 10;
        Debug.Log("Cubo Gravedad" + Gravedad);

        Densidad = 8;
        Debug.Log("Cubo Densidad" + Densidad);

        Da�o = 0;
        Debug.Log("Cubo Da�o" + Da�o);

        Tama�o = 1;
        Debug.Log("Cubo Tama�o" + Tama�o);

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
