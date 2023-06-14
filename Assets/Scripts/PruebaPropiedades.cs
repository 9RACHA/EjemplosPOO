using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPropiedades : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        EjemploPropiedades ep = new EjemploPropiedades();

        ep.PropiedadSimple = 8;
        ep.PropiedadCompleja = 7;
        ep.PropiedadCompleja = 4;

        Debug.Log("**** OBJETO ep ****");
        Debug.Log("Valor de PropiedadSimple: " + ep.PropiedadSimple + " Valor de PropiedadCompleja: " + ep.PropiedadCompleja);
        Debug.Log("Valor de SumaSimpleCompleja: " + ep.SumaSimpleCompleja); 

        EjemploPropiedades ep2 = new EjemploPropiedades();

        ep2.PropiedadSimple = 15;
        ep2.PropiedadCompleja = 13;

        Debug.Log("**** OBJETO ep2 ****");
        Debug.Log("Valor de PropiedadSimple: " + ep2.PropiedadSimple + " Valor de PropiedadCompleja: " + ep.PropiedadCompleja);
        Debug.Log("Valor de SumaSimpleCompleja: " + ep2.SumaSimpleCompleja); 

        EjemploPropiedades.PropiedadSimpleEstatica = 100;

        Debug.Log("**** Propiedad Estática ****");   
        Debug.Log("Valor de PropiedadSimpleEstatica: " + EjemploPropiedades.PropiedadSimpleEstatica);

    }

}
