using System.Collections;
using System.Collections.Generic;

public class Util {

    // Método estático para ordenar una lista genérica utilizando el algoritmo de selección
    public static void OrdenarLista<T>(List<T> listaOrdenar) where T : IComparable {
        // Recorremos la lista desde el primer elemento hasta el penúltimo elemento
        for (int i = 0; i < listaOrdenar.Count; i++) {
            // Recorremos la lista desde el siguiente elemento hasta el último elemento
            for (int j = i + 1; j < listaOrdenar.Count; j++) {
                // Comparamos los elementos utilizando el método Menor() de la interfaz IComparable
                if (listaOrdenar[j].Menor(listaOrdenar[i])) {
                    // Intercambiamos los objetos en las posiciones i y j
                    T aux = listaOrdenar[j];
                    listaOrdenar[j] = listaOrdenar[i];
                    listaOrdenar[i] = aux;
                }
            }
        }
    }
}

/*
    public static void OrdenarLista(IComparable[] arrayOrdenar) {
        for(int i=0; i<arrayOrdenar.Length; i++) {
            for(int j=i+1; j<arrayOrdenar.Length; j++) {
                if(arrayOrdenar[j].Menor(arrayOrdenar[i])) {
                    //Intercambio los objetos en las posiciones i y j
                    IComparable aux = arrayOrdenar[j];
                    arrayOrdenar[j] = arrayOrdenar[i];
                    arrayOrdenar[i] = aux;                     
                }
            }
        }

    }
*/

