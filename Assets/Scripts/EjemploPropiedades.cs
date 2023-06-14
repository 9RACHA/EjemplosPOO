using UnityEngine;

public class EjemploPropiedades : ISaludador {
    // Propiedad simple estática
    public static int PropiedadSimpleEstatica { get; set; }

    // Propiedad simple
    public int PropiedadSimple { get; set; }

    // Campo privado para la propiedad compleja
    private int propiedadCompleja;

    // Propiedad compleja con validación
    public int PropiedadCompleja {
        get { return propiedadCompleja; }
        set {
            // Validación: el valor debe ser mayor o igual a 5
            if (value >= 5) {
                propiedadCompleja = value;
            } else {
                Debug.Log($"El valor {value} no es válido para PropiedadCompleja");
            }
        }
    }

    // Propiedad de solo lectura que retorna la suma de la propiedad simple y la propiedad compleja
    public int SumaSimpleCompleja {
        get { return this.PropiedadSimple + this.PropiedadCompleja; }
    }

    // Implementación del método Saluda() de la interfaz ISaludador
    public string Saluda() {
        return "Te saluda " + SumaSimpleCompleja;
    }
}
