using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaISaluda : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        EjemploPropiedades ep = new EjemploPropiedades();
        Saludar(ep); // Llamada al método Saludar pasando el objeto ep como argumento
    }

    private void Saludar(ISaludador saludador) {
        Debug.Log(saludador.Saluda()); // Llama al método Saluda() del objeto que implementa la interfaz ISaludador y muestra el resultado en la consola
    }
}

