using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSobrecarga : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        // Llamada al método Sumar con dos enteros
        EjemploSobrecarga.Sumar(3, 5);
        
        // Llamada al método Sumar con dos floats
        EjemploSobrecarga.Sumar(3.4f, 0.4f);

        // Llamada al método Sumar con un entero y un float
        EjemploSobrecarga.Sumar(3, 3.4f);

        // Llamada al método Multiplicar con dos enteros
        EjemploSobrecarga.Multiplicar(3, 5);
        
        // Llamada al método Multiplicar con dos floats
        EjemploSobrecarga.Multiplicar(3.4f, 0.4f);

        // Llamada al método Multiplicar con una cadena y un entero
        Debug.Log(EjemploSobrecarga.Multiplicar("Ola", 3));       
    }
}

