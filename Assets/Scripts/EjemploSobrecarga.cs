using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploSobrecarga {
    // Sobrecarga del método Sumar para enteros
    public static int Sumar(int s1, int s2) {
        Debug.Log("Sumar enteros");
        return s1 + s2;
    }

    // Sobrecarga del método Sumar para floats
    public static float Sumar(float s1, float s2) {
        Debug.Log("Sumar float");
        return s1 + s2;
    }

    // Sobrecarga del método Sumar para un entero y un float
    public static float Sumar(int s1, float s2) {
        Debug.Log("Sumar int + float");
        return s1 + s2;
    }

    // Sobrecarga del método Multiplicar para enteros
    public static int Multiplicar(int s1, int s2) {
        Debug.Log("Multiplicar enteros");
        return s1 * s2;
    }

    // Sobrecarga del método Multiplicar para floats
    public static float Multiplicar(float s1, float s2) {
        Debug.Log("Multiplicar float");
        return s1 * s2;
    }

    // Sobrecarga del método Multiplicar para multiplicar una cadena por un entero
    public static string Multiplicar(string str, int n) {
        Debug.Log("Multiplicar string * int");
        string resultado = "";
        for (int i = 0; i < n; i++) {
            resultado += str;
        }
        return resultado;
    }
}
